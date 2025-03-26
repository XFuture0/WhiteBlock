using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheck : MonoBehaviour
{
    public bool IsGround;
    [Header("GroundBoxCast")]
    public Vector2 GroundBoxPoint1;
    public Vector2 GroundBoxPoint2;
    public LayerMask Ground;
    private void Update()
    {
        CheckIsGround();
    }
    private void CheckIsGround()
    {
        IsGround = Physics2D.OverlapArea((Vector2)transform.position + GroundBoxPoint1, (Vector2)transform.position + GroundBoxPoint2, Ground);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere((Vector2)transform.position + GroundBoxPoint1, 0.02f);
        Gizmos.DrawSphere((Vector2)transform.position + GroundBoxPoint2, 0.02f);
    }
}
