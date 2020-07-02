using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeBean : MonoBehaviour
{
    Rigidbody rbCoffeeBean;
    public bool inBlade = false;

    void Start()
    {
        rbCoffeeBean = GetComponent<Rigidbody>();

    } // Start()

    void Update()
    {
        if (inBlade)
        {
            rbCoffeeBean.velocity = new Vector3(0, -0.2f, 0);         
        }

    } // Update()

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LowerBoundry"))
        {
            Destroy(this.gameObject);
        }

    } // OnTriggerEnter()

} // sınıf
