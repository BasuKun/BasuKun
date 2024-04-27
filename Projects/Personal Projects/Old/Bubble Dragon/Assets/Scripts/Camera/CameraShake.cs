using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public IEnumerator CameraShaker(float intensity, float duration)
    {
        Vector3 originalPos = transform.position;

        float timer = duration;

        while (timer > 0)
        {
            float xRandom = Random.Range(-1f, 1f) * intensity * timer;
            float yRandom = Random.Range(-1f, 1f) * intensity * timer;

            transform.position = new Vector3(xRandom, yRandom, -10);

            timer -= Time.deltaTime;

            yield return null;
        }

        transform.position = originalPos;
    }
}
