using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BreakableWalls : MonoBehaviour
{
    public int hp;
    public int wallSize;
    public Tilemap groundMap;
    public Tilemap tilemap;
    public TileBase fullTileOutsides;
    public TileBase fullTileMiddle;
    public TileBase fullTileGround;
    public TileBase brokenTileOutsides;
    public TileBase brokenTileMiddle;
    public TileBase brokenTileGround;
    public TileBase emptyTile;
    private Grid grid;

    public void Awake()
    {
        grid = GetComponentInParent<Grid>();
    }

    public void Start()
    {
        UpdateTiles();
        SetCollision();
    }

    public void SetCollision()
    {
        for (int i = 0; i < wallSize - 1; i++)
        {
            Vector3Int lPos = grid.WorldToCell(this.transform.position);
            groundMap.SetTile(new Vector3Int(lPos.x, lPos.y - i, lPos.z), emptyTile);
        }
    }

    public void UpdateTiles()
    {
        for (int i = 0; i < wallSize; i++)
        {
            TileBase tile;
            Vector3Int currentTilePos = new Vector3Int(0, -i, 0);

            switch (i)
            {
                case 0:
                    tile = hp == 2 ? fullTileOutsides : brokenTileOutsides;
                    tilemap.SetTile(currentTilePos, tile);
                    break;
                case 1:
                    tile = hp == 2 ? fullTileMiddle : brokenTileMiddle;
                    tilemap.SetTile(currentTilePos, tile);
                    break;
                case 2:
                    tile = hp == 2 ? fullTileOutsides : brokenTileOutsides;
                    tilemap.SetTile(currentTilePos, tile);
                    break;
                case 3:
                    tile = hp == 2 ? fullTileGround : brokenTileGround;
                    tilemap.SetTile(currentTilePos, tile);
                    break;
            }
        }
    }

    public void RemoveHP(int amount)
    {
        hp -= amount;

        if (hp == 0)
        {
            Vector3Int lPos = grid.WorldToCell(this.transform.position);

            for (int i = 0; i < wallSize - 1; i++)
            {
                groundMap.SetTile(new Vector3Int(lPos.x, lPos.y - i, lPos.z), null);
            }
            Destroy(gameObject);
        }
        UpdateTiles();
    }
}
