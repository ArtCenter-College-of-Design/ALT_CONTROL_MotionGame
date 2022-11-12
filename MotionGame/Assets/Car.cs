using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public CarManafer carM;


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedN = speed + carM.gameDiff;
        rb.velocity = transform.forward * speedN;
    }
}
