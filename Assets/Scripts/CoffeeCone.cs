using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeCone : MonoBehaviour
{
    private Vector3 startPosition;
    private float shakeTimer;
    private Vector3 randomPosition;
    [Range(0f, 2f)]
    public float tmpTime = 0.2f;
    [Range(0f, 2f)]
    public float shakeDistance = 0.1f;
    [Range(0f, 0.1f)]
    public float delayBetweenShakes = 0f;

    private void Awake()
    {
        startPosition = transform.position;

    } // Awake()

    private void OnValidate()
    {
        if (delayBetweenShakes > tmpTime)
            delayBetweenShakes = tmpTime;

    } // OnValidate()

    public void Begin()
    {
        StopAllCoroutines();
        StartCoroutine(Shake());

    } // Begin()

    private IEnumerator Shake()
    {
        shakeTimer = 0f;

        while (shakeTimer < tmpTime)
        {
            shakeTimer += Time.deltaTime;

            randomPosition = startPosition + (Random.insideUnitSphere * shakeDistance);

            transform.position = randomPosition;

            if (delayBetweenShakes > 0f)
            {
                yield return new WaitForSeconds(delayBetweenShakes);
            }
            else
            {
                yield return null;
            }
        }

        transform.position = startPosition;

    } // Shake()

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Begin();
        }

    } // OnMouseOver()

} // sınıf
