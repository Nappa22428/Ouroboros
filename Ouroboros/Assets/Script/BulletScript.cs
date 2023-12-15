using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 sD;
    public float mSpeed = 1f;
    float xS;
    float yS;
   
    private Vector3 vel;

    public Rigidbody2D rb;
    public followMouse w;

    public void Setup(Vector3 sD)
    {
        this.sD = sD;
    }
    private void Update()
    {
        transform.position += new Vector3(sD.x, sD.y, 0) * mSpeed * Time.deltaTime;
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

        }
        else
        {
            Destroy(gameObject, 0f);
        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void flip(Collision2D other)
    {
        float speed = rb.velocity.magnitude;
        Vector3 dir = Vector2.Reflect(rb.velocity.normalized, other.contacts[0].normal);
        rb.velocity = dir;
    }
  
}
