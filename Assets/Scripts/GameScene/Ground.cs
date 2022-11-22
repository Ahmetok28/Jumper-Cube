using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float jumpForce;
    public bool touchGround;
    int jumpposibility;
    public static float lastPlatformY;

    Animator anim;
    private void Start()
    {
        jumpposibility = Random.Range(1, 11);
        anim = GetComponent<Animator>();

        if (jumpposibility==1)
        {


            anim.Play("JumperGround");
            jumpForce = 23f;
        }
        else
        {
           
            jumpForce =16;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 jumpVelocity = rb.velocity;
                jumpVelocity.y = jumpForce;
                rb.velocity = jumpVelocity;

                if (touchGround == false)
                {
                    GameManager.score++;
                    touchGround = true;
                   
                }
                lastPlatformY = gameObject.transform.position.y;
                anim.SetBool("Touching", true);
                Destroy(gameObject, 1f);

            }          
        }
    }

    
}