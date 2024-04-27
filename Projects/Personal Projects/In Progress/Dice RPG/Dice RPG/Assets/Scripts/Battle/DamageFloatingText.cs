using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Febucci.UI;

public class DamageFloatingText : MonoBehaviour
{
    public TextAnimator damageText;
    public Rigidbody2D rig;

    private void Awake()
    {
        rig.AddForce(new Vector2(0f + Random.Range(-3000f, 3000f), (10000f + Random.Range(-1000f, 1000f))), ForceMode2D.Impulse);
        Destroy(this.gameObject, 3f);
    }

    private void Update()
    {
        rig.gravityScale += Time.deltaTime * 10;
    }

    public void UpdateDamageText(int damage)
    {
        damageText.SetText("<wiggle><fade>" + damage + "</fade></wiggle>", false);
    }
}
