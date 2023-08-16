using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectCScript : MonoBehaviour
{
    public Transform objectA;
    public Transform objectB;
    public TextMeshProUGUI TimeDisplay;

    private float moveDuration = 5f;
    private float t = 0f;
    private float elapsedTime = 0f;

    void Start()
    {
        StartCoroutine(MoveToB());
    }

    private IEnumerator MoveToB()
    {
        
        elapsedTime = 0;
        while (elapsedTime < moveDuration)
        {
            elapsedTime += Time.deltaTime;
            t = elapsedTime / moveDuration;
            TimeDisplay.text = elapsedTime.ToString("F3");
            transform.position = Vector3.Lerp(objectA.position, objectB.position, t);
            yield return null;
        }

    }
}
