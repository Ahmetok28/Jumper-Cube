using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    private float horizontalInput;
   
    
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

  
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * moveSpeed * Time.deltaTime, rb.velocity.y);
        Vector2 newScale = transform.localScale;


        if (horizontalInput > 0)
        {
            newScale.x = 0.35f;
        }
        else if (horizontalInput < 0)
        {
            newScale.x = -0.35f;
        }

        transform.localScale = newScale;
        if (gameObject.transform.position.y<Ground.lastPlatformY-2)
        {
            SceneManager.LoadScene(2);
            Ground.lastPlatformY = 0;
           
        }
        

    }


}
