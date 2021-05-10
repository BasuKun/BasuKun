using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickInstantButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    private float pointerDownTimer = 0.5f;
    private float timeNeeded = 0.5f;
    private float acceleration = 1.05f;
    private float maxAcceleration = 0.04f;
    private float pitchRaiser = 0f;

    Coroutine loopSFX = null;
    Coroutine stopLoopSFX = null;

    public UnityEvent onLongClick;

    public Image fillImage;
    public ParticleSystem absorbAnimation;
    private ParticleSystem anim = null;

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;

        if (GameManager.Instance.GMData.snowflakesAmount >= GameManager.Instance.GMData.absorbedSnowflakesAmount)
        {
            anim = Instantiate(absorbAnimation);

            if (stopLoopSFX != null) StopCoroutine(stopLoopSFX);
            loopSFX = StartCoroutine(AudioManager.Instance.FadeIn(AudioManager.Instance.absorbLoopSFX, 2f, Mathf.SmoothStep));
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pitchRaiser = 0;
        Reset();
    }

    private void Update()
    {
        if (pointerDown && GameManager.Instance.GMData.snowflakesAmount >= GameManager.Instance.GMData.absorbedSnowflakesAmount)
        {
            InfoPopupHandler.Instance.DespawnInfoPopup();

            var emission = anim.emission;
            emission.rateOverTime = 1 + (100 - timeNeeded * 200);

            pointerDownTimer += Time.deltaTime;
            if (pointerDownTimer >= timeNeeded)
            {
                if (onLongClick != null)
                {
                    onLongClick.Invoke();

                    if (GameManager.Instance.GMData.absorbedSnowflakes == 0f)
                    {
                        pitchRaiser = Mathf.Clamp(pitchRaiser + 0.03f, 0f, 1f);
                        AudioManager.Instance.PlayRaisingSound(AudioManager.Instance.absorbHitSFX, 0.9f + pitchRaiser);
                    }

                    fillImage.fillAmount = (float)GameManager.Instance.GMData.absorbedSnowflakes / 10f;
                    timeNeeded = Mathf.Clamp(timeNeeded / (acceleration + Powerups.Instance.AbsorbantBody()), maxAcceleration - (Powerups.Instance.AbsorbantBody() / 10f), 0.5f);
                }
                if (GameManager.Instance.GMData.snowflakesAmount >= GameManager.Instance.GMData.absorbedSnowflakesAmount)
                {
                    pointerDownTimer = 0;
                }
                else
                {
                    Reset();
                }
            }
        }
    }

    private void Reset()
    {
        if (anim != null)
        {
            Destroy(anim.gameObject);
            anim = null;
        }

        if (loopSFX != null)
        {
            StopCoroutine(loopSFX);
            stopLoopSFX = StartCoroutine(AudioManager.Instance.FadeOut(1f, Mathf.SmoothStep));
        }

        pointerDown = false;
        pointerDownTimer = 0.5f;
        timeNeeded = 0.5f;
        fillImage.fillAmount = (float)GameManager.Instance.GMData.absorbedSnowflakes / 10f;
    }

}