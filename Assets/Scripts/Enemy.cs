using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health1 = 10;
    

    public void TakeDamage(int damage)
    {
        health1 -= damage;
        if(health1 <=0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
