using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicItem : MonoBehaviour
{
    public ItemData ItemData;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            InvertoryManager.Instance.AddItem(ItemData);
            Destroy(gameObject);
        }
    }
}
