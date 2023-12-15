using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    Collider2D cc;
    PAController PAC;
    public Vector2 tDirection;
    SpriteRenderer spriteRenderer;
    PlayerMove player;
    public bool isDead;
    public float speed;

    public int health = 5;

    public int bulletCount = 1;

    public bool bulletsAngled = false;
    public float angleLimit = 15f;
    public float shootCooldownMin = 0.5f;
    public float shootCooldownMax = 1f;

    public float requiredPathDistance = 5f;

    public EnemyBullet bullet;

    public Transform shootPoint;

    GameManager gm;
    public bool isShooter;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<Collider2D>();
        PAC = GetComponent<PAController>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = FindObjectOfType<PlayerMove>();
        gm = FindObjectOfType<GameManager>();
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FixedUpdate()
    {
        UpdateTargetDirection();
        SetVelocity();
        deathCheck();
        flip();
        if (isShooter)
        {
            Shoot();
        }
    }

    public void deathCheck()
    {
        if (health <=0)
        {
            isDead = true;
            animator.SetBool("IsDead", true);
        }
    }

    private void UpdateTargetDirection()
    {
        if (PAC.AwareOfPlayer == true)
        {
            tDirection = PAC.DirectionToPlayer;
            //animator.SetBool("isMoving", true);
        }
        else
        {
            tDirection = Vector2.zero;
            //animator.SetBool("isMoving", false);
        }
    }

    private void flip()
    {
        if (tDirection.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (tDirection.x < 0)
        {
            spriteRenderer.flipX = true;
        }

    }

    private void SetVelocity()
    {
        if (tDirection == Vector2.zero || isDead)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            //speed = ((float)es.eDex) / 100;
            rb.velocity = (tDirection * speed * Time.fixedDeltaTime);
        }
    }
    public void Dead()
    {
        gm.EnemiesLeft --;
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            health--;
        }
    }

    private IEnumerator Shoot()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (!((distance > requiredPathDistance) || isDead))
        {
            if (bulletCount > 1)
            {
                float[] angles = Linspace(-angleLimit, angleLimit, bulletCount);

                for (int i = 0; i < bulletCount; i++)
                {
                    EnemyBullet newBullet;

                    Quaternion rotationOffset = Quaternion.Euler(0, Random.Range(-5f, 5f), 0);
                    newBullet = Instantiate(bullet, shootPoint.position, transform.rotation * rotationOffset);
                    newBullet.transform.Rotate(0, angles[i], 0);
                    
                }
            }
            else
            {
               
                
                    EnemyBullet newBullet;
                    newBullet = Instantiate(bullet, shootPoint.position, transform.rotation);
                

            }
        }


        float cooldownTime = Random.Range(shootCooldownMin, shootCooldownMax);
        yield return new WaitForSeconds(cooldownTime);
        if (!isDead) StartCoroutine(Shoot());
    }

    public float[] Linspace(float start, float stop, int num)
    {
        float[] result = new float[num];
        if (num == 1)
        {
            result[0] = start;
            return result;
        }

        float step = (stop - start) / (num - 1);
        for (int i = 0; i < num; i++)
        {
            result[i] = start + i * step;
        }
        return result;
    }
}
