using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaguinhoScript : MonoBehaviour
{
    public float velocity, jumpForce;
    private bool jump;
   private Rigidbody2D body;
   private SpriteRenderer render;
    void Start()
    {
        this.jump = false;
        this.body = this.GetComponent<Rigidbody2D>();
        this.render = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputKeyHorizontal = Input.GetAxis("Horizontal");

        if (inputKeyHorizontal > 0)
        {
            this.body.AddForce(new Vector2(this.velocity, 0));
            this.render.flipX = false;
        }
        else if (inputKeyHorizontal < 0)
        {
            this.body.AddForce(new Vector2(-this.velocity, 0));
            this.render.flipX = true;
        }

        if (Input.GetButton("Jump") && !this.jump)
        {
            this.jump = true;
            this.body.AddForce(new Vector2(0, this.jumpForce));
        }
        else if (this.body.velocity.y == 0 && this.jump)
        {
            this.jump = false;            
        }

    }
}
