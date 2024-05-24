using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGeneration : MonoBehaviour
{
    [SerializeField] NoiseGeneration noiseGeneration;
    [SerializeField] TextureBuilding textureBuilding;
    [SerializeField] BiomeBuilding biomeBuilding;
    [SerializeField] private MeshFilter meshFilter;
    [SerializeField] private MeshCollider meshCollider;
    [SerializeField] private MeshRenderer tileRenderer;
    [SerializeField] private float levelScale;
    [SerializeField] private TerrainType[] heightTerrainTypes;
    [SerializeField] private TerrainType[] heatTerrainTypes;
    [SerializeField] private TerrainType[] moistureTerrainTypes;
    [SerializeField] private float heightMultiplier;
    [SerializeField] private AnimationCurve heightCurve;
    [SerializeField] private Wave[] heightWaves;
    [SerializeField] private Wave[] heatWaves;
    [SerializeField] private Wave[] moistureWaves;
    [SerializeField] private VisualizationMode visualizationMode;

    public void GenerateTile(float centerVertexZ, float maxDistanceZ)
    {
        Vector3[] meshVertices = this.meshFilter.mesh.vertices;
        int tileDepth = (int)Mathf.Sqrt(meshVertices.Length);
        int tileWidth = tileDepth;

        float offsetX = -this.gameObject.transform.position.x;
        float offsetZ = -this.gameObject.transform.position.z;

        Vector3 tileDimensions = this.meshFilter.mesh.bounds.size;
        float distanceBetweenVertices = tileDimensions.z / (float)tileDepth;
        float vertexOffsetZ = this.gameObject.transform.position.z / distanceBetweenVertices;

        float[,] heightMap = noiseGeneration.GeneratePerlinNoiseMap(tileWidth, tileDepth, levelScale, offsetX, offsetZ, heightWaves);

        TerrainType[,] chosenHeightTerrainTypes = new TerrainType[tileWidth, tileDepth];
        Texture2D heightTexture = textureBuilding.BuildTexture(heightMap, heightTerrainTypes, chosenHeightTerrainTypes);

        float[,] uniformHeatMap = noiseGeneration.GenerateUniformNoiseMap(tileWidth, tileDepth, centerVertexZ, maxDistanceZ, vertexOffsetZ);
        float[,] randomHeatMap = noiseGeneration.GeneratePerlinNoiseMap(tileWidth, tileDepth, levelScale, offsetX, offsetZ, heatWaves);
        float[,] heatMap = new float[tileWidth, tileDepth];
        for (int xIndex = 0; xIndex < tileWidth; xIndex++)
        {
            for (int zIndex = 0; zIndex < tileDepth; zIndex++)
            {
                heatMap[xIndex, zIndex] = uniformHeatMap[xIndex, zIndex] * randomHeatMap[xIndex, zIndex];

                TerrainType heightTerrainType = chosenHeightTerrainTypes[xIndex, zIndex];
                if (heightTerrainType.name == "mountain")
                {
                    heatMap[xIndex, zIndex] += 0.8f * heightMap[xIndex, zIndex];
                }
                else
                {
                    heatMap[xIndex, zIndex] += 0.5f * heightMap[xIndex, zIndex];
                }
            }
        }

        float[,] moistureMap = noiseGeneration.GeneratePerlinNoiseMap(tileWidth, tileDepth, levelScale, offsetX, offsetZ, moistureWaves);
        for (int xIndex = 0; xIndex < tileWidth; xIndex++)
        {
            for (int zIndex = 0; zIndex < tileDepth; zIndex++)
            {
                TerrainType heightTerrainType = chosenHeightTerrainTypes[xIndex, zIndex];
                if (heightTerrainType.name == "water")
                {
                    moistureMap[xIndex, zIndex] += 0.7f * heightMap[xIndex, zIndex];
                }
                else
                {
                    moistureMap[xIndex, zIndex] -= 0.1f * heightMap[xIndex, zIndex];
                }
            }
        }

        TerrainType[,] chosenHeatTerrainTypes = new TerrainType[tileWidth, tileDepth];
        Texture2D heatTexture = textureBuilding.BuildTexture(heatMap, heatTerrainTypes, chosenHeatTerrainTypes);

        TerrainType[,] chosenMoistureTerrainTypes = new TerrainType[tileWidth, tileDepth];
        Texture2D moistureTexture = textureBuilding.BuildTexture(moistureMap, moistureTerrainTypes, chosenMoistureTerrainTypes);

        Biome[,] chosenBiomes = new Biome[tileWidth, tileDepth];
        Texture2D biomeTexture = biomeBuilding.BuildBiomeTexture(chosenHeightTerrainTypes, chosenHeatTerrainTypes, chosenMoistureTerrainTypes, chosenBiomes);

        switch (this.visualizationMode)
        {
            case VisualizationMode.Height:
                this.tileRenderer.material.mainTexture = heightTexture;
                break;
            case VisualizationMode.Heat:
                this.tileRenderer.material.mainTexture = heatTexture;
                break;
            case VisualizationMode.Moisture:
                this.tileRenderer.material.mainTexture = moistureTexture;
                break;
            case VisualizationMode.Biome:
                this.tileRenderer.material.mainTexture = biomeTexture;
                break;
        }

        UpdateMeshVertices(heightMap);
    }

    private void UpdateMeshVertices(float[,] heightMap)
    {
        int tileWidth = heightMap.GetLength(0);
        int tileDepth = heightMap.GetLength(1);

        Vector3[] meshVertices = this.meshFilter.mesh.vertices;

        for (int xIndex = 0; xIndex < tileWidth; xIndex++)
        {
            for (int zIndex = 0; zIndex < tileDepth; zIndex++)
            {
                int vertexIndex = zIndex * tileWidth + xIndex;

                float height = heightMap[xIndex, zIndex];

                Vector3 vertex = meshVertices[vertexIndex];
                meshVertices[vertexIndex] = new Vector3(vertex.x, this.heightCurve.Evaluate(height) * heightMultiplier,vertex.z);
            }
        }

        this.meshFilter.mesh.vertices = meshVertices;
        this.meshFilter.mesh.RecalculateBounds();
        this.meshFilter.mesh.RecalculateNormals();
        this.meshCollider.sharedMesh = this.meshFilter.mesh;
    }
}

enum VisualizationMode{Height, Heat, Moisture, Biome}
