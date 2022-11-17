using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isH = false;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.GetComponent<Car>() != null)
        {
            if (isH)
            {
                Debug.Log("!");
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().SetTrigger("shake");
                CarManafer.time -= 50f;
            }

            CarManafer.score++;
            Car car = other.GetComponent<Car>();
            Vector3 newVector = this.gameObject.transform.position - other.gameObject.transform.position;
            car.rb.freezeRotation = false;
            car.rb.AddForce(newVector * -300f);
            car.rb.AddForce(Vector3.up * 300f);
            car.rb.AddForce(Vector3.forward * -200f);
            car.isMoving = false;
            car.DestroyCar();

        }
    }
}
