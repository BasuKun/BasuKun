using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflake : MonoBehaviour
{
    public float baseValue = 1;
    public float fallSpeed = 8f;
    public float fallingCooldown = 1f;
    public Snowflake snowflake;
    public GameObject sfObject;
    public GameObject pileTile;
    public GameObject pileGroup;
    public ParticleSystem snowBurst;
    private bool wentLeft = true;
    private bool isPiling = false;

    void Start()
    {
        pileGroup = GameObject.FindGameObjectWithTag("Floor");
        snowflake = gameObject.GetComponent<Snowflake>();
        sfObject = this.gameObject;
        wentLeft = (Random.value > 0.5f);
    }

    void Update()
    {
        isPiling = false;
        fallingCooldown -= Time.deltaTime * fallSpeed;

        if (fallingCooldown <= 0f)
        {
            FallingMovement();
        }

        if (transform.position.y <= -Screen.height / 80)
        {
            Destroy(gameObject);
        }
    }

    void FallingMovement()
    {
        transform.position = wentLeft ?
            new Vector2(transform.position.x + 0.2f, transform.position.y - 0.2f) :
            new Vector2(transform.position.x - 0.2f, transform.position.y - 0.2f);

        wentLeft = !wentLeft;
        fallingCooldown = 1f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MouseRadius")
        {
            ParticleSystem burst = Instantiate(snowBurst, transform.position, Quaternion.identity);
            GameManager.Instance.collectSnowflakes(baseValue);
        }

        else if ((collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Pile") && !isPiling)
        {
            isPiling = true;

            float tile = ((int)(transform.position.x / 0.25f)) * 0.25f + 0.125f;

            for (float y = -4.38f; y < 0; y += 0.25f)
            {
                if (!PileHandler.Instance.pileDict.ContainsKey(new Vector3(tile, y, 0)))
                {
                    GameObject pile = Instantiate(pileTile, new Vector3(tile, y, 0), Quaternion.identity);
                    PileHandler.Instance.pileDict.Add(pile.transform.position, pile);
                    PileHandler.Instance.AutoTile();
                    pile.transform.parent = pileGroup.transform;

                    break;
                }

                else
                {
                    continue;
                }
            }
        }

        Destroy(gameObject);
    }
}