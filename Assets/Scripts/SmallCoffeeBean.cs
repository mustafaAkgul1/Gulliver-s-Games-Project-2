using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCoffeeBean : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LowerBoundry"))
        {
            Destroy(this.gameObject);
        }
    }

} // sınıf
