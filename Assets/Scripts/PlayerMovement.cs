using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private Rigidbody2D playerRb;
    private Collider2D playerCol;
    private float dirX;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerCol = GetComponent<Collider2D>();    
    }


    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        playerRb.velocity = new Vector2(dirX * moveSpeed, playerRb.velocity.y);
    }
}
