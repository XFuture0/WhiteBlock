using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public Itemimage itemimage;
    public void UpdateItemData(ItemData itemData)
    {
        itemimage.gameObject.SetActive(true);
        itemimage.UpdateImage(itemData);
    }
}
