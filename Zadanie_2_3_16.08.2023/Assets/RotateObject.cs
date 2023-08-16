using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public TextMeshProUGUI TimeDisplay;

    private Quaternion rotationStartValues;
    private Quaternion rotationEndValues;
    private float moveDuration = 5f;
    private float t = 0f;
    private float elapsedTime = 0f;

    void Start()
    {
        rotationStartValues = transform.rotation;
        rotationEndValues = Quaternion.Euler(0f,0f, 90f);
        StartCoroutine(RotateObject90(rotationStartValues, rotationEndValues));
    }

    private IEnumerator RotateObject90(Quaternion rotationStartValues, Quaternion rotationEndValues)
    {
        elapsedTime = 0;
        while (elapsedTime < moveDuration)
        {
            elapsedTime += Time.deltaTime;
            t = elapsedTime / moveDuration;
            TimeDisplay.text = elapsedTime.ToString("F3");
            transform.rotation = Quaternion.Lerp(rotationStartValues, rotationEndValues, t);
            yield return null;
        }

    }
}
