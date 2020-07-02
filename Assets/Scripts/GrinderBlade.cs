using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrinderBlade : MonoBehaviour
{
    public float rotationSpeed = 25f;

    void Update()
    {
        transform.Rotate(new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));

    } // Update()

} // sınıf
