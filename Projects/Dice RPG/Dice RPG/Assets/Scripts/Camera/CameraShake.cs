using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public IEnumerator CameraShaker(float intensity, float duration)
    {
        Vector3 originalPos = Camera.main.transform.position;

        float timer = duration;

        while (timer > 0)
        {
            float xRandom = Random.Range(-1f, 1f) * intensity * timer;
            float yRandom = Random.Range(-1f, 1f) * intensity * timer;

            Camera.main.transform.position = new Vector3(originalPos.x + xRandom, originalPos.y + yRandom, -10); 

            timer -= Time.deltaTime;

            yield return null;
        }

        Camera.main.transform.position = originalPos;
        yield return null;
    }
}