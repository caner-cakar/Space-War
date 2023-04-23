using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed=20f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int playerDamage = 10;

    
    [SerializeField] private GameObject impactEffect;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy!=null)
        {
            enemy.TakeDamage(playerDamage);
            Destroy(GameObject.FindGameObjectWithTag("Impact"));
        }
        else if (hitInfo.CompareTag("Wall"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Impact"));
        }
        Instantiate(impactEffect,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
