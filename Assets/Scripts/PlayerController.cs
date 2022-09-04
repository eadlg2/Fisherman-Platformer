using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D player;

    public float speed;
    public float jumpForce;

    private bool isJumping;

    void Start() {
        isJumping = false;

        player = GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move() {
        float x = Input.GetAxis("Horizontal");
        float moveBy = x * speed;
        player.velocity = new Vector2(moveBy, player.velocity.y);
    }

    void Jump() {
        if (isJumping == false) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                player.velocity = new Vector2(player.velocity.x, jumpForce);
                isJumping = true;
            }
        } 

        if (player.velocity.y == 0) {
            isJumping = false;
        }
    }
}
