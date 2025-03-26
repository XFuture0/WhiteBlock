using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerCheck Check;
    private Rigidbody2D rb;
    private float InputX;
    [Header("¡Ÿ ± Ù–‘")]
    public float Speed;
    public float JumpForce;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Check = rb.GetComponent<PlayerCheck>();
    }
    private void Update()
    {
        Jump();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        InputX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(InputX * Speed * Time.deltaTime, rb.velocity.y);
        if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void Jump()
    {
        if (KeyBoardManager.Instance.GetKeyDown_Space() && Check.IsGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
        }
    }
}
