using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbAnimation : MonoBehaviour
{
    void Update()
    {
        if (GameManager.Instance.GMData.snowflakesAmount < GameManager.Instance.GMData.absorbedSnowflakesAmount)
        {
            Destroy(this.gameObject);
        }
    }
}
