using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public void DealDamage()
    {
        Battle.Instance.DealDamage(true, Player.Instance.damageToDeal);
    }

    public void DealSkillDamage()
    {
        Battle.Instance.DealDamage(false, Player.Instance.damageToDeal);
    }

    public void DealDamageEnemy()
    {
        Battle.Instance.ReceiveDamage();
    }

    public void Summon()
    {
        Player.Instance.ActivateSummons();
    }
}
