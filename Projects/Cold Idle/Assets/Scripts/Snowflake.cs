using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflake : MonoBehaviour
{
    public float fallSpeed = 8f;
    public float fallingCooldown = 1f;
    public Snowflake snowflake;
    public GameObject sfObject;
    public GameObject pileTile;
    public GameObject pileGroup;
    public ParticleSystem snowBurst;
    public ParticleSystem doubleSnowBurst;
    public SnowflakeSpawner snowflakeSpawner;
    private bool wentLeft = true;
    private bool isPiling = false;
    private bool isBursting;
    private bool isBeingDestroyed = false;
    public bool isSelectedByCollector = false;
    public bool isDouble = false;

    void Start()
    {
        isSelectedByCollector = false;
        pileGroup = GameObject.FindGameObjectWithTag("Floor");
        snowflakeSpawner = GameObject.FindObjectOfType<SnowflakeSpawner>();
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

        if (collision.gameObject.tag == "MouseRadius" && !isSelectedByCollector)
        {
            GameManager.Instance.collectSnowflakes(GameManager.Instance.snowflakeValue, isDouble ? true : false, this.transform.position);
            isBursting = true;
        }

        else if ((collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Pile") && !isPiling && !isSelectedByCollector)
        {
            isPiling = true;

            float tile = ((int)(transform.position.x / 0.25f)) * 0.25f + 0.125f;

            for (float y = -4.38f; y < GameManager.Instance.snowpileHeightLimit; y += 0.25f)
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
            isBursting = false;
        }

        if (!isBeingDestroyed && !isSelectedByCollector)
        {
            DestroySnowflake(isBursting);
        }  
    }

    public void DestroySnowflake(bool isBursting)
    {
        isBeingDestroyed = true;

        if(isBursting)
        {
            ParticleSystem burst = Instantiate(isDouble ? doubleSnowBurst : snowBurst, transform.position, Quaternion.identity);
        }

        snowflakeSpawner.currentSnowflakesList.Remove(gameObject);
        Destroy(gameObject);
    }
}