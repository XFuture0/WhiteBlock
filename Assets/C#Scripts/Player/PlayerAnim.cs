using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        PlayerRun();
    }
    private void PlayerRun()
    {
        anim.SetFloat("Speed",math.abs(rb.velocity.x));
    }
    public void PlayerJumpDown_On()
    {
        anim.SetBool("JumpDown", true);
    }
    public void PlayerJumpDown_End()
    {
        anim.SetBool("JumpDown", false);
    }
}
