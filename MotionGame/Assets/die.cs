using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public float timee;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timee);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
