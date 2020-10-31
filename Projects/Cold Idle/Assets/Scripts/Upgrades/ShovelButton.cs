using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ShovelButton : MonoBehaviour
{
    public Button button;
    public ParticleSystem snowBurst;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (PileHandler.Instance.pileDict.Count > 0)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void ShovelSnow()
    {
        System.Random rand = new System.Random();
        int index = rand.Next(0, PileHandler.Instance.pileDict.Count);
        Vector3 indexVector = new Vector3(
            PileHandler.Instance.pileDict.ElementAt(index).Value.transform.position.x, 
            PileHandler.Instance.pileDict.ElementAt(index).Value.transform.position.y,
            PileHandler.Instance.pileDict.ElementAt(index).Value.transform.position.z);
        Destroy(PileHandler.Instance.pileDict.ElementAt(index).Value);
        ParticleSystem burst = Instantiate(snowBurst, indexVector, Quaternion.identity);

        GameManager.Instance.collectSnowflakes((int)(GameManager.Instance.snowflakeValue / 2), false, true, new Vector3(burst.transform.position.x, burst.transform.position.y + 0.15f, burst.transform.position.z));
        GameManager.Instance.collectIceBlocks((int)(GameManager.Instance.snowflakeValue / 2) + 1, burst.transform.position);

        PileHandler.Instance.pileDict.Remove(indexVector);

        for (float y = -4.38f + 0.25f; y < 0; y += 0.25f)
        {
            Vector3 curTile = new Vector3(indexVector.x, y, 0);
            Vector3 belowTile = new Vector3(indexVector.x, y - 0.25f, 0);

            if (PileHandler.Instance.pileDict.ContainsKey(curTile))
            {
                if (!PileHandler.Instance.pileDict.ContainsKey(belowTile))
                {
                    PileHandler.Instance.pileDict[curTile].transform.position = belowTile;
                    PileHandler.Instance.pileDict.Add(belowTile, PileHandler.Instance.pileDict[curTile]);
                    PileHandler.Instance.pileDict.Remove(curTile);
                }
            }
        }

        PileHandler.Instance.AutoTile();
    }
}
