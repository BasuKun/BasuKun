using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteInEditMode]
public class AutoTiling : MonoBehaviour
{
    private Tilemap tilemap;
    public TileBase[] templateTileSet = new TileBase[48];
    public TileBase[] cavernGroundVariations = new TileBase[3];

    public void AutoTile()
    {
        tilemap = GetComponent<Tilemap>();
        CalculateValues();
    }

    void CalculateValues()
    {
        for (int x = -25; x < 25; x++)
        {
            for (int y = -25; y < 25; y++)
            {
                Vector3Int pos = new Vector3Int(x, y, 0);
                if (!tilemap.HasTile(pos)) continue;

                Vector3Int posNW = new Vector3Int(x-1, y+1, 0);
                Vector3Int posN = new Vector3Int(x, y+1, 0);
                Vector3Int posNE = new Vector3Int(x+1, y+1, 0);
                Vector3Int posW = new Vector3Int(x-1, y, 0);
                Vector3Int posE = new Vector3Int(x+1, y, 0);
                Vector3Int posSW = new Vector3Int(x-1, y-1, 0);
                Vector3Int posS = new Vector3Int(x, y-1, 0);
                Vector3Int posSE = new Vector3Int(x+1, y-1, 0);
                int value = 0;

                value += tilemap.HasTile(posNW) && tilemap.HasTile(posN) && tilemap.HasTile(posW) ? 1 : 0;
                value += tilemap.HasTile(posN) ? 2 : 0;
                value += tilemap.HasTile(posNE) && tilemap.HasTile(posN) && tilemap.HasTile(posE) ? 4 : 0;
                value += tilemap.HasTile(posW) ? 8 : 0;
                value += tilemap.HasTile(posE) ? 16 : 0;
                value += tilemap.HasTile(posSW) && tilemap.HasTile(posS) && tilemap.HasTile(posW) ? 32 : 0;
                value += tilemap.HasTile(posS) ? 64 : 0;
                value += tilemap.HasTile(posSE) && tilemap.HasTile(posS) && tilemap.HasTile(posE) ? 128 : 0;

                SetTile(pos, value);
            }
        }
    }

    void SetTile(Vector3Int pos, int value)
    {
        int bitMaskValue = 0;

        if (value >= 2 && value < 8) bitMaskValue = 1;
        else if (value >= 8 && value < 10) bitMaskValue = 2;
        else if (value >= 10 && value < 11) bitMaskValue = 3;
        else if (value >= 11 && value < 16) bitMaskValue = 4;
        else if (value >= 16 && value < 18) bitMaskValue = 5;
        else if (value >= 18 && value < 22) bitMaskValue = 6;
        else if (value >= 22 && value < 24) bitMaskValue = 7;
        else if (value >= 24 && value < 26) bitMaskValue = 8;
        else if (value >= 26 && value < 27) bitMaskValue = 9;
        else if (value >= 27 && value < 30) bitMaskValue = 10;
        else if (value >= 30 && value < 31) bitMaskValue = 11;
        else if (value >= 31 && value < 64) bitMaskValue = 12;
        else if (value >= 64 && value < 66) bitMaskValue = 13;
        else if (value >= 66 && value < 72) bitMaskValue = 14;
        else if (value >= 72 && value < 74) bitMaskValue = 15;
        else if (value >= 74 && value < 75) bitMaskValue = 16;
        else if (value >= 75 && value < 80) bitMaskValue = 17;
        else if (value >= 80 && value < 82) bitMaskValue = 18;
        else if (value >= 82 && value < 86) bitMaskValue = 19;
        else if (value >= 86 && value < 88) bitMaskValue = 20;
        else if (value >= 88 && value < 90) bitMaskValue = 21;
        else if (value >= 90 && value < 91) bitMaskValue = 22;
        else if (value >= 91 && value < 94) bitMaskValue = 23;
        else if (value >= 94 && value < 95) bitMaskValue = 24;
        else if (value >= 95 && value < 104) bitMaskValue = 25;
        else if (value >= 104 && value < 106) bitMaskValue = 26;
        else if (value >= 106 && value < 107) bitMaskValue = 27;
        else if (value >= 107 && value < 120) bitMaskValue = 28;
        else if (value >= 120 && value < 122) bitMaskValue = 29;
        else if (value >= 122 && value < 123) bitMaskValue = 30;
        else if (value >= 123 && value < 126) bitMaskValue = 31;
        else if (value >= 126 && value < 127) bitMaskValue = 32;
        else if (value >= 127 && value < 208) bitMaskValue = 33;
        else if (value >= 208 && value < 210) bitMaskValue = 34;
        else if (value >= 210 && value < 214) bitMaskValue = 35;
        else if (value >= 214 && value < 216) bitMaskValue = 36;
        else if (value >= 216 && value < 218) bitMaskValue = 37;
        else if (value >= 218 && value < 219) bitMaskValue = 38;
        else if (value >= 219 && value < 222) bitMaskValue = 39;
        else if (value >= 222 && value < 223) bitMaskValue = 40;
        else if (value >= 223 && value < 248) bitMaskValue = 41;
        else if (value >= 248 && value < 250) bitMaskValue = 42;
        else if (value >= 250 && value < 251) bitMaskValue = 43;
        else if (value >= 251 && value < 254) bitMaskValue = 44;
        else if (value >= 254 && value < 255) bitMaskValue = 45;
        else if (value >= 255 && value < 256) bitMaskValue = 46;
        else if (value >= 0 && value < 2) bitMaskValue = 47;

        tilemap.SetTile(pos, templateTileSet[bitMaskValue]);

        RandomizeGround(pos, bitMaskValue);
    }

    void RandomizeGround(Vector3Int pos, int bitMaskValue)
    {
        if (bitMaskValue == 42)
        {
            int random = Random.Range(0, 3);
            tilemap.SetTile(pos, cavernGroundVariations[random]);
        }
    }

}
