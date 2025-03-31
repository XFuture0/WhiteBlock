using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatBag : MonoBehaviour
{
    public Invertory hatbag;
    public List<ItemSlot> itemSlots = new List<ItemSlot>();
    private void OnEnable()
    {
        Refresh();
    }
    private void Refresh()
    {
        for(int i = 0; i < itemSlots.Count; i++)
        {
            if (itemSlots[i].itemimage.gameObject.activeSelf)
            {
                itemSlots[i].itemimage.gameObject.SetActive(false);
            }
            if(hatbag.InvertoryDatas[i].ItemData != null)
            {
                itemSlots[i].UpdateItemData(hatbag.InvertoryDatas[i].ItemData);
            }
        }
    }
}
