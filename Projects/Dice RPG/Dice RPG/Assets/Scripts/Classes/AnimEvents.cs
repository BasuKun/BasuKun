using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public void DealDamage()
    {
        Battle.Instance.DealDamage(true);
    }

    public void DealSkillDamage()
    {
        Battle.Instance.DealDamage(false);
    }

    public void DealDamageEnemy()
    {
        Battle.Instance.ReceiveDamage();
    }
}
