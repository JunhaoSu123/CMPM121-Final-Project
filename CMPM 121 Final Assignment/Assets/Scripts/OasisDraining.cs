using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OasisDraining : MonoBehaviour
{
    public static float OasisHealth;
    public float DrainingSpeed = 0.2f;
    private float DrainingCooldown = 0f;

    void Start()
    {
        OasisHealth = 110f;
    }

    void Update()
    {
        DrainingCooldown -= Time.deltaTime;
        if (OasisHealth != 0)
        {
            Draining();
        }
        if (OasisHealth <= 0)
        {
            
            SceneManager.LoadScene(6);
        }
        if (OasisHealth >= 110)
        {
            OasisHealth = 110;

        }
    }
    public void Draining()
    {
        if (DrainingCooldown <= 0f)
        {
            OasHealthValue.OasishealthValue -= 10f;
            OasisHealth = OasisHealth - 10f;
            //Debug.Log("The Oasis'health is" + OasisHealth);
            DrainingCooldown = 1f / DrainingSpeed;
        }

    }

}
