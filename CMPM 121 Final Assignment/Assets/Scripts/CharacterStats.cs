﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stats damage;
    
    void Awake()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.T))
        //{
          //  TakeDamage(10);
       // }
    }
    public void TakeDamage (int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        Debug.Log(transform.name + "takes" + damage + "damage.");

        if (currentHealth <= 0)
        {
            Die();
            SceneManager.LoadScene(6);
        }
    }

    public virtual void Die()
    {
        Debug.Log(transform.name + "died.");
    }
}
