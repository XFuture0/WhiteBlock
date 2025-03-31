using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Enemy
{
    private CharacterStats EnemyData;
    private Rigidbody2D rb;
    [Header("基本属性")]
    public float Speed;
    [Header("检测墙面")]
    public bool IsWall;
    public Vector2 GroundBoxPoint1;
    public Vector2 GroundBoxPoint2;
    public LayerMask Ground;
    private void Awake()
    {
        EnemyData = GetComponent<CharacterStats>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        CheckIsWall();
        ChangeFace();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        rb.velocity = new Vector2(-Speed * Time.deltaTime, rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            EnemyData.Attack(EnemyData, other.gameObject.GetComponent<CharacterStats>());
        }
    }
    private void CheckIsWall()
    {
        IsWall = Physics2D.OverlapArea((Vector2)transform.position + GroundBoxPoint1, (Vector2)transform.position + GroundBoxPoint2, Ground);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere((Vector2)transform.position + GroundBoxPoint1, 0.02f);
        Gizmos.DrawSphere((Vector2)transform.position + GroundBoxPoint2, 0.02f);
    }
    private void ChangeFace()
    {
        if (IsWall)
        {
            Speed = -Speed;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            GroundBoxPoint1.x = -GroundBoxPoint1.x;
            GroundBoxPoint2.x = -GroundBoxPoint2.x;
        }
    }
}
