using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int _score;
    public CarManafer cm;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("score") != null && GameObject.FindGameObjectWithTag("score") != this.gameObject) Destroy(this.gameObject);
        else DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void fixedUpdate()
    {
     
    }
}
