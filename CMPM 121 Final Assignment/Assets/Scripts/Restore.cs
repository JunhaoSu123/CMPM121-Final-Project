using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restore : MonoBehaviour
{
    public GameObject WaterSource;
    private bool dropWater = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (dropWater == true && Item.count != 0)
        {
            if (Input.GetKeyDown("s"))
            {
                WaterSource.gameObject.SetActive(true);
                Item.count = 0;
                OasisDraining.OasisHealth = OasisDraining.OasisHealth + 40f;
                OasHealthValue.OasishealthValue = OasHealthValue.OasishealthValue + 40f;
                //Debug.Log("OasisHealth + 30");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        dropWater = true;
            //Debug.Log("You can drop the source"); 
    }

    void OnTriggerExit(Collider other)
    {
        dropWater = false;
        
    }
}
