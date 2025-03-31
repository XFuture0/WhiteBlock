using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("¹ã²¥")]
    public VoidEvenSO GetCoinEvent;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetCoinEvent.RaiseEvent();
            Destroy(gameObject);
        }
    }

}
