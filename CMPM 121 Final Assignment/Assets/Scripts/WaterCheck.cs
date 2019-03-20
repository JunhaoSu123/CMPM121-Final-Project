using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterCheck : MonoBehaviour
{
    public GameObject Check;
    // Start is called before the first frame update
    void Start()
    {
        Check.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Item.count == 0)
        {
            Check.SetActive(false);
        }
        if (Item.count == 1)
        {
            Check.SetActive(true);
        }
    }
}
