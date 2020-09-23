using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Jump : MonoBehaviour
{
    float speed = 8f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y >= 0f)
        {
            Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();
            if(rigidbody != null)
            {
                Vector2 velocity = rigidbody.velocity;
                velocity.y = speed;
                rigidbody.velocity = velocity;
            }
        }
        


    }
}
