using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteract : Interactable
{
    PlayerManager playerManager;

    public override void Interact()
    {
        base.Interact();
    }
    // Start is called before the first frame update
    void Start()
    {
        playerManager = PlayerManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
