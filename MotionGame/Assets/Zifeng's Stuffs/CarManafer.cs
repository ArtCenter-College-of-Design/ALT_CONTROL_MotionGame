using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CarManafer : MonoBehaviour
{
    public int sco = 0;
    public int hea = 5;

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
      
        text.text = "Score: " + sco + "\nHealth: " + hea;
        gameDiff += Time.fixedDeltaTime/3;
        canBeHit -= Time.fixedDeltaTime;
        Debug.Log(canBeHit);
        if (hea <= 0)
        {
            if (GameObject.FindGameObjectWithTag("score") != null) GameObject.FindGameObjectWithTag("score").GetComponent<score>()._score = sco;
            SceneManager.LoadScene(2);
            //end scene;
        }

        for (int i = 0; i < times.Length; i++)
        {
            times[i] -= Time.fixedDeltaTime;
            if (times[i] < 0)
            {
                float time = 10f - gameDiff;
                if (time < 4) time = 4;
                times[i] = Random.Range(.3f, time);
                GameObject car = Instantiate(cars[Random.Range(0,cars.Length)], new Vector3(positions[i].position.x, positions[i].position.y, positions[i].transform.position.z), Quaternion.identity) as GameObject;
                car.GetComponent<Car>().carM = this;
            }

        }
    }
}
