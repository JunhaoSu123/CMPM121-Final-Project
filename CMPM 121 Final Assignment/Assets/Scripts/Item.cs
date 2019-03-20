using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Interactable
{
    
    public static int count;

    void Start()
    {
        count = 0;
    }
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        //Debug.Log("Picking up WATER");
        gameObject.SetActive(false);
        Count();
    }
    void Count()
    {
        count = 1;
    }
}
