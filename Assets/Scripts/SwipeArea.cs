using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeArea : MonoBehaviour
{
    public float forcePower = 15f;
    List<Collider> onSwipeAreaList = new List<Collider>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SmallCoffeeBean"))
        {
            if (!onSwipeAreaList.Contains(other))
            {
                onSwipeAreaList.Add(other);
            }
        }

    } // OnTriggerEnter()

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SmallCoffeeBean"))
        {
            if (onSwipeAreaList.Contains(other))
            {
                onSwipeAreaList.Remove(other);
            }
        }

    } // OnTriggerExit()

    public void SwipeButtonAction()
    {
        if (onSwipeAreaList.Count > 0)
        {
            foreach (Collider smallCoffeeBean in onSwipeAreaList)
            {
                if (smallCoffeeBean != null)
                {
                    // yaymak için güç vermeyi denedim fakat istediğim sonucu elde edemedim. bu yüzden direk silmeyi tercih ettim.
                    // smallCoffeeBean.GetComponent<Rigidbody>().AddForce(new Vector3(-forcePower, -forcePower * 2, -forcePower));

                    Destroy(smallCoffeeBean.gameObject);
                    //onSwipeAreaList.Remove(smallCoffeeBean);
                }
            }

            onSwipeAreaList.Clear();

        } // if onSwipeAreaList.Count

    } // SwipeButtonAction()

} // sınıf
