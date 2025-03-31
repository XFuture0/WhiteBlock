using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterStats PlayerStats;
    private PlayerCheck Check;
    private PlayerAnim Anim;
    private Rigidbody2D rb;
    private float InputX;
    public PlayerData PlayerData;
    [Header("¡Ÿ ± Ù–‘")]
    private float Speed;
    private float JumpForce;
    private float JumpDownSpeed_Max;
    private void Awake()
    {
        PlayerStats = GetComponent<CharacterStats>();
        rb = GetComponent<Rigidbody2D>();
        Check = rb.GetComponent<PlayerCheck>();
        Anim = rb.GetComponent<PlayerAnim>();
        RefreshData();
    }
    private void OnEnable()
    {
        LoadPlayerData();
        DataManager.Instance.Save(PlayerData,"PlayerData");
    }
    private void Update()
    {
        Jump();
        PlayerJumpDown();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void RefreshData()
    {
        Speed = PlayerData.Speed;
        JumpForce = PlayerData.JumpForce;
        JumpDownSpeed_Max = PlayerData.JumpDownSpeed_Max;
    }
    private void Move()
    {
        InputX = KeyBoardManager.Instance.GetHorizontalRaw();
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
        if(!Check.IsGround && rb.velocity.y < 0)
        {
            if(rb.velocity.y <= JumpDownSpeed_Max)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpDownSpeed_Max);
            }
        }  
    }
    private void PlayerJumpDown()
    {
        if(KeyBoardManager.Instance.GetKey_S() && KeyBoardManager.Instance.GetKeyDown_J())
        {
            PlayerStats.IsProtected = true;
            KeyBoardManager.Instance.StopAnyKey = true;
            rb.velocity = Vector2.zero;
            gameObject.GetComponent<Collider2D>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
            Anim.PlayerJumpDown_On();
        }
    }
    private IEnumerator JumpDownEnd()
    {
        yield return new WaitForSeconds(0.5f);
        KeyBoardManager.Instance.StopAnyKey = false;
        transform.GetChild(0).gameObject.SetActive(false);
        gameObject.GetComponent<Collider2D>().enabled = true;
        Anim.PlayerJumpDown_End();
        yield return new WaitForSeconds(1f);
        PlayerStats.IsProtected = false;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (transform.GetChild(0).gameObject.activeSelf)
        {
            rb.gravityScale = Settings.PlayerGravity;
            StartCoroutine(JumpDownEnd());
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (transform.GetChild(0).gameObject.activeSelf && other.gameObject.tag == "Enemy")
        {
            PlayerStats.Attack(PlayerStats, other.gameObject.GetComponent<CharacterStats>());
        }
    }
    private void LoadPlayerData()
    {
        if (PlayerPrefs.HasKey("PlayerData"))
        {
            DataManager.Instance.Load(PlayerData, "PlayerData");
            RefreshData();
        }
    }
}
