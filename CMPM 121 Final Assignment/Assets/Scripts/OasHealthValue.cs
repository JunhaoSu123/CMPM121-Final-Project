using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OasHealthValue : MonoBehaviour
{
    Image Oasishealth;
    float OasismaxHealth = 100f;
    public static float OasishealthValue;
    // Start is called before the first frame update
    void Start()
    {
        Oasishealth = GetComponent<Image>();
        OasishealthValue = 110f;
    }

    // Update is called once per frame
    void Update()
    {
        if (OasishealthValue >= 110f)
        {
            OasishealthValue = 110f;
        }

            Oasishealth.fillAmount = OasishealthValue / OasismaxHealth;
    
    }
}

