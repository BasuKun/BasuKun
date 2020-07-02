using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BreakableWalls : MonoBehaviour
{
    public int hp;
    public int wallSize;
    public Tilemap tilemap;
    public TileBase fullTile;
    public TileBase brokenTile;

    public void Start()
    {
        UpdateTiles();
    }

    public void UpdateTiles()
    {
        for (int i = 0; i > -wallSize; i--)
        {
            Vector3Int currentTilePos = new Vector3Int(0, i, 0);
            TileBase tile = hp == 2 ? fullTile : brokenTile;
            tilemap.SetTile(currentTilePos, tile);
        }
    }

    public void RemoveHP(int amount)
    {
        hp -= amount;

        if (hp == 0)
        {
            Destroy(gameObject);
        }
        UpdateTiles();
    }
}
