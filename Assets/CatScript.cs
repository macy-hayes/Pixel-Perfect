using System;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    public Rigidbody2D catRB;
    public float speed;
    public float input;
    public SpriteRenderer spriteRenderer;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        
        if(input < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(input > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
    void FixedUpdate()
    {
        catRB.linearVelocity = new Vector2(input * speed, catRB.linearVelocityY);
        animator.SetFloat("xVelocity", Math.Abs(catRB.linearVelocity.x));
    }
}
