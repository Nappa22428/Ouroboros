using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public int damage = 2;
    public float lifespan = 3f;

    [SerializeField] bool followsPlayer;
    [SerializeField] Rigidbody rb;
    PlayerMove player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMove>();
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        ControlMovement();
    }

    // Handle where and when the bullet moves
    private void ControlMovement()
    {
        if (!player.canMove)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
            if (followsPlayer) transform.LookAt(player.transform);
            rb.velocity = transform.forward * speed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Hitting enemy, remove health from said enemy
        if (other.gameObject.CompareTag("Player"))
        {

                other.gameObject.GetComponent<PlayerMove>().RecieveDamage(damage);
                Destroy(gameObject);

        }
        else if (!other.gameObject.CompareTag("Enemy Bullet") && other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
