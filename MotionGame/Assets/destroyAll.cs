using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAll : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Car>() != null)
        {

            Destroy(other.gameObject);

        }
    }
}
