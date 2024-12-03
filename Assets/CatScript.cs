using UnityEngine;

public class CatScript : MonoBehaviour
{
    public Rigidbody2D catRB;
    public float speed;
    public float input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        
    }
    void FixedUpdate()
    {
        catRB.linearVelocity = new Vector2(input * speed, catRB.linearVelocityY);
    }
}
