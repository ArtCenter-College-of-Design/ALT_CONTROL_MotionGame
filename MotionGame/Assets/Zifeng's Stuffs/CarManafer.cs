using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarManafer : MonoBehaviour
{
    public static int score = 0;
    public static int health = 5;

    public static float canBeHit;
    public TMP_Text text;

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
      
        text.text = "Score: " + score + "\nHealth: " + health;
        gameDiff += Time.fixedDeltaTime/5;
        canBeHit -= Time.fixedDeltaTime;
        Debug.Log(canBeHit);
        if (health <= 0)
        { 
        
        //end scene;
        }

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
