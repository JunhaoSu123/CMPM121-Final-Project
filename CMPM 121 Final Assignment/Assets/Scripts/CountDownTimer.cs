﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    [SerializeField] Text Countdown;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Countdown.text = currentTime.ToString("0");
        if(currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(5);
        }
    }
    
}
