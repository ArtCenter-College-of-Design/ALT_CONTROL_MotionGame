using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCollider : MonoBehaviour
{
    public string attachName;

    public GameObject attachTo;

    private void Update()
    {
        if (attachTo == null && GameObject.Find(attachName) != null)
        {
            attachTo = GameObject.Find(attachName);
        }

        if (attachTo != null)
        {
            this.transform.position = attachTo.transform.position;
            this.transform.eulerAngles = new Vector3(attachTo.transform.rotation.x, attachTo.transform.rotation.y, attachTo.transform.rotation.z);
                
                
        }
           
    }

}
