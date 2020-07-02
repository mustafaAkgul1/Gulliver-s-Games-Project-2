using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityArea : MonoBehaviour
{
    public GameObject smallBean;
    public GameObject extractionPoint;
    public int maxSmallBeanCount = 15;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoffeeBean"))
        {
            other.GetComponent<Rigidbody>().useGravity = false;
            other.GetComponent<CoffeeBean>().inBlade = true;
        }

    } // OnTriggerEnter()

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CoffeeBean"))
        {
            CreateSmallBeans(other.transform.position);
            Destroy(other.gameObject);
        }

    } // OnTriggerExit()

    void CreateSmallBeans(Vector3 position)
    {
        for (int i = 0; i < maxSmallBeanCount; i++)
        {
            Instantiate(smallBean, position, Quaternion.identity);
        }

    } // CreateSmallBeans()


    //private void OnTriggerExit(Collider other) //random saçılarak araya mesafe koymak için test
    //{
    //    if (other.CompareTag("CoffeeBean"))
    //    {
    //        Debug.Log("parçalandı");
    //        for (int i = 0; i < maxSmallBeanCount; i++)
    //        {
    //            Vector3 tmpPos = other.transform.position;
    //            float tmpX = 0.005f;
    //            float tmpZ = 0.005f;

    //            tmpPos.x += Random.Range(-tmpX, tmpX);
    //            tmpPos.z += Random.Range(-tmpZ, tmpZ);

    //            Vector3 tmpPos1 = other.transform.position;
    //            float tmpX1 = 0.005f;
    //            float tmpZ1 = 0.005f;

    //            tmpPos1.x += Random.Range(-tmpX1, tmpX1);
    //            tmpPos1.z += Random.Range(-tmpZ1, tmpZ1);

    //            Instantiate(smallBean, tmpPos, Quaternion.identity);

    //            Instantiate(smallBean, tmpPos1, Quaternion.identity);

    //        }

    //        Destroy(other.gameObject);

    //    } // if tag

    //} // OnTriggerExit()


} // sınıf
