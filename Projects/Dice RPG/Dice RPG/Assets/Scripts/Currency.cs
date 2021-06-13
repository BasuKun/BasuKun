using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public Rigidbody2D rig;

    void Awake()
    {
        rig.AddForce(new Vector2(Random.Range(-4f, 4f), Random.Range(-4f, 4f)), ForceMode2D.Impulse);
        StartCoroutine(FlyTowardsPlayer());
    }

    private IEnumerator FlyTowardsPlayer()
    {
        yield return new WaitForSeconds(Random.Range(0.8f, 1.4f));

        while (gameObject.transform.position.x > Player.Instance.character.gameObject.transform.position.x)
        {
            gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, Player.Instance.character.gameObject.transform.position - new Vector3(0.2f, 0f, 0f), Time.deltaTime * Random.Range(0.5f, 2.3f));
            yield return new WaitForFixedUpdate();
        }

        Player.Instance.soulsCurrency++;
        GameUI.Instance.UpdateSoulsCurrencyText();

        Destroy(this.gameObject);
        yield return null;
    }
}
