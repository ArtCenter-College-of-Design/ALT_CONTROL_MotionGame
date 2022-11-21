using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class End : MonoBehaviour
{
    public TMP_Text text;
    public void StartGame()
    {
        SceneManager.LoadScene(0);
        

    }

    public void Start()
    {
        if (GameObject.FindGameObjectWithTag("score") != null) text.text = GameObject.FindGameObjectWithTag("score").GetComponent<score>()._score + " score";
    }
}
