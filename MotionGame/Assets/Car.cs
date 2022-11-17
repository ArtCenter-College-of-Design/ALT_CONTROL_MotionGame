using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Car : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody rb;
    public CarManafer carM;

    public bool isMoving;
    public GameObject prefab;
    public bool isS = true;


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        transform.eulerAngles = new Vector3(0, 180, 0);
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            float speedN = speed + carM.gameDiff;
            rb.velocity = transform.forward * -speedN;
        }
     
    }

    public void DestroyCar()
    {
        StartCoroutine(destoryLate());
    }

    public IEnumerator destoryLate()
    {
        if (isS)
        {
            GameObject go = Instantiate(prefab, this.gameObject.transform.position, Quaternion.identity) as GameObject;
            isS = false;
        }
     
        yield return new WaitForSeconds(3f);
        if (this.gameObject != null)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Car>() != null)
        {
            CarManafer.score++;
            Car car = other.GetComponent<Car>();
            if (car != null)
            {
                Vector3 newVector = this.gameObject.transform.position - other.gameObject.transform.position;
                car.rb.freezeRotation = false;
                car.rb.AddForce(newVector * 300f);
                car.rb.AddForce(Vector3.up * 300f);
                car.isMoving = false;
                car.DestroyCar();
            }
           
        }
    }
}
