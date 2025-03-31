using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPile : MonoBehaviour
{
    private bool IsPlayerJumpDown;
    public GameObject Coin;
    public int Count;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerJumpDown = GameManager.Instance.PlayerStats.gameObject.transform.GetChild(0).gameObject.activeSelf;
            if (IsPlayerJumpDown)
            {
                GiveBonus();
            }
        }
    }

    private void GiveBonus()
    {
        for(int i = 0; i < Count;i++)
        {
            var NewCoin = Instantiate(Coin, transform.position, Quaternion.identity);
            var CoinSpeed = new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f));
            NewCoin.GetComponent<Rigidbody2D>().velocity = CoinSpeed * 10f;
        }
        Destroy(gameObject);
    }
}
