using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManafer : MonoBehaviour
{
    public Transform[] positions;
    public float[] times;
    public GameObject[] cars;

    public float gameDiff;

    void Start()
    {
        for (int i = 0; i < times.Length; i++)
        {
            times[i] = Random.Range(1, 4f);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameDiff += Time.fixedDeltaTime/100;

        for (int i = 0; i < times.Length; i++)
        {
            times[i] -= Time.fixedDeltaTime;
            if (times[i] < 0)
            {
                times[i] = Random.Range(.3f, 10f);
                GameObject car = Instantiate(cars[Random.Range(0,cars.Length)], new Vector3(positions[i].position.x, positions[i].position.y, positions[i].transform.position.z), Quaternion.identity) as GameObject;
                car.GetComponent<Car>().carM = this;
            }

        }
    }
}
