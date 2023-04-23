using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health1 = 10;

    private float downSpeed = 2f;
    private Rigidbody2D rb;

    public void TakeDamage(int damage)
    {
        health1 -= damage;
        if(health1 <=0)
        {
            Die();
            Score.instance.ScoreUpdate();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        rb.velocity = new Vector2(rb.velocity.x, -1* downSpeed);
    }

    private void OnCollisionEnter2D(Collision2D coll) 
    {
        if(coll.gameObject.CompareTag("Player"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        else if(coll.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
