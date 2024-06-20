using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMove : MonoBehaviour{
    public float runSpeed=2;
    public float jumpSpeed=3;
    private Rigidbody2D rb2D;

    public bool betterJump = false;  //mejora el salto (si aprieta poco salta poco y si aprieta mucho salta mucho)
    public float fallMultiplier = 0.5f;

    public float lowJumpMultiplier = 1;

    public SpriteRenderer spriteRenderer;

    void Start(){
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        if (Input.GetKey("right")){
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);    //moverse a la derecha
            spriteRenderer.flipX = true;   //el Duck mira a la derecha
        } 
        else if (Input.GetKey("left")){
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);    //moverse a la izquierda
            spriteRenderer.flipX = false;   //el Duck mira a la derecha
        }
        else {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);    //cuando no se toca teclas se queda quieto
        }

        if (Input.GetKey("up") && CheckGround.isGrounded){
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }

        if (betterJump){
            if (rb2D.velocity.y < 0){
                rb2D.velocity += Vector2.up*Physics2D.gravity.y*(fallMultiplier)*Time.deltaTime;  
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("up")){
                rb2D.velocity += Vector2.up*Physics2D.gravity.y*(lowJumpMultiplier)*Time.deltaTime;
            }
        }
    }
}
