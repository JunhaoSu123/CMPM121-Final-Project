﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Image health;
    float maxHealth = 100f;
    public static float healthValue;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Image>();
        healthValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health.fillAmount = healthValue / maxHealth;
    }
}
