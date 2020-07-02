﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    [SerializeField] private int levelWidthInTiles, levelDepthInTiles;
    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private float centerVertexZ, maxDistanceZ;

    void Start()
    {
        Vector3 tileSize = tilePrefab.GetComponent<MeshRenderer>().bounds.size;
        int tileWidth = (int)tileSize.x;
        int tileDepth = (int)tileSize.z;

        for (int xTileIndex = 0; xTileIndex < levelWidthInTiles; xTileIndex++)
        {
            for (int zTileIndex = 0; zTileIndex < levelDepthInTiles; zTileIndex++)
            {
                Vector3 tilePosition = new Vector3(
                    this.gameObject.transform.position.x + xTileIndex * tileWidth, 
                    this.gameObject.transform.position.y,
                    this.gameObject.transform.position.z + zTileIndex * tileDepth);

                GameObject tile = Instantiate(tilePrefab, tilePosition, Quaternion.identity) as GameObject;
                tile.GetComponent<TileGeneration>().GenerateTile(centerVertexZ, maxDistanceZ);
            }
        }
    }
}
