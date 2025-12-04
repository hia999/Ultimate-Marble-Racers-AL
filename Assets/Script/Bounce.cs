using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5000f;
    private bool isBouncing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "wall")
        {
            float bounce = 600f;
            rb.AddForce(collision.contacts[0].normal * bounce);
        }
    }
}
