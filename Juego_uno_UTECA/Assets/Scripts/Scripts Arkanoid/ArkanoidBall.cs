using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBall : MonoBehaviour
{
    [SerializeField] private Vector2 initialVelocity;

    private Rigidbody2D ballRb;
    private bool isBallMoving;
    
    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isBallMoving)
        {
            ballVelocity();
        }
    }

    private void ballVelocity()
    {
        transform.parent = null;
        ballRb.velocity = initialVelocity;
        isBallMoving = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bloque"))
        {
            Destroy(collision.gameObject);
        }
    }
}
