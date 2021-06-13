using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering.PostProcessing;

public class EllipsePositions : MonoBehaviour
{
    public Transform character;
    public Transform rotationCenter;
    public SpriteRenderer characterSprite;
    public TextMeshProUGUI selectedText;
    public PostProcessVolume colorFilter;
    public int currentSelected = (int)CurrentClass.classes.Ronin;
    private float rotationRadius = 1.35f;
    private float angularSpeed = 2f;
    public float posX, posY, angle = 0f;
    public bool isTurning;

    public static EllipsePositions Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        StartCoroutine(RotateCharacters(true, true));
    }

    public void OnTurnButtonPress(bool isClockwise)
    {
        if (!isTurning) StartCoroutine(RotateCharacters(false, isClockwise));        
    }

    public IEnumerator RotateCharacters(bool isStart, bool isClockwise)
    {
        isTurning = true;

        if (isClockwise) currentSelected -= currentSelected == 1 ? -5 : 1;
        else currentSelected += currentSelected == 6 ? -5 : 1;
        selectedText.text = ((CurrentClass.classes)currentSelected).ToString();

        colorFilter.sharedProfile.GetSetting<ColorGrading>().gamma.value = ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].gamma;

        while (IsInSpotlight(isClockwise))
        {
            foreach (var character in ClassesObjects.Instance.characters)
            {
                character.Value.gameObject.GetComponentInChildren<SpriteMask>().enabled = true;
                if (character.Key == (CurrentClass.classes)currentSelected) character.Value.gameObject.GetComponentInChildren<SpriteMask>().enabled = false;

                posX = rotationCenter.position.x + Mathf.Cos(angle - character.Value.selectionScreenAngle) * rotationRadius;
                posY = rotationCenter.position.y + Mathf.Sin(angle - character.Value.selectionScreenAngle) * rotationRadius / 4f;

                characterSprite = character.Value.gameObject.GetComponentInChildren<SpriteRenderer>();
                character.Value.gameObject.transform.position = new Vector2(posX, posY);

                float scale = 1f - Mathf.Max(0, posY + 0.2f);
                character.Value.gameObject.transform.localScale = new Vector2(scale, scale);
            }

            angle = isClockwise ? angle + Time.deltaTime * angularSpeed : angle + Time.deltaTime * -angularSpeed;

            if (!isStart) yield return new WaitForFixedUpdate();
        }

        isTurning = false;
        yield return null;
    }

    private bool IsInSpotlight(bool isClockwise)
    {
        if (isClockwise) return ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].gameObject.transform.position.x < 0f;
        else return ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].gameObject.transform.position.x > 0f;
    }

    private void SetSpriteOrders(Class currentClass)
    {
        foreach (var character in ClassesObjects.Instance.characters)
        {
            character.Value.GetComponentInChildren<SpriteRenderer>().sortingOrder = 0;
        }
        currentClass.GetComponentInChildren<SpriteRenderer>().sortingOrder = 2;
    }
}
