using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public int health = 10;

    Vector2 movementInput;
    public Vector2 tempPosition;
    
    Rigidbody2D rb;
    Collider2D c2d;
    SpriteRenderer spriteRenderer;
    
    public ContactFilter2D movementFilter;

    Animator animator;

    
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    public TextMeshProUGUI tHealth;
    
    public bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        c2d = GetComponent<BoxCollider2D>();
        canMove = true;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            RecieveDamage(1);
        }
    }
    private void FixedUpdate()
    {
        movement();
        deathCheck();
        healthUpdate();
    }

    public void healthUpdate()
    {
        tHealth.text = "Health = " + health;
    }

    public void movement()
    {
        if (canMove)
        {
            if (movementInput != Vector2.zero)
            {

                bool success = TryMove(movementInput);

                if (!success)
                {
                    success = TryMove(new Vector2(movementInput.x, 0));
                }
                if (!success)
                {
                    success = TryMove(new Vector2(0, movementInput.y));
                }
                if (movementInput.x < 0)
                {
                    spriteRenderer.flipX = true;
                }
                if (movementInput.x > 0)
                {
                    spriteRenderer.flipX = false;
                }
                animator.SetBool("isMoving", success);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
        }
    }

    private bool TryMove(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            int count = c2d.Cast(
                direction,
                movementFilter,
                castCollisions,
                moveSpeed * Time.fixedDeltaTime + collisionOffset);

            if (count == 0)
            {
                rb.MovePosition(rb.position + direction * (moveSpeed) * Time.fixedDeltaTime);
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    private void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }

    public void RecieveDamage(int d)
    {
        health -= d;
    }

    public void deathCheck()
    {
        if(health <= 0)
        {
            canMove = false;
            animator.SetBool("IsDead", true);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
