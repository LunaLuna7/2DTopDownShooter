using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    // Update is called once per frame
    void Update()
    {
        
    }

   public void Damage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
