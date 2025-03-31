using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Invertory",menuName ="Data/New Invertory")]
public class Invertory : ScriptableObject
{
    private bool IsFound;
    [System.Serializable]
    public class InvertoryData
    {
        public ItemData ItemData;
    }
    public List<InvertoryData> InvertoryDatas = new List<InvertoryData>();
    public void AddItem(ItemData itemdata)
    {
        IsFound = false;
        foreach (var item in InvertoryDatas)
        {
            if(item.ItemData == itemdata)
            {
                IsFound = true;
            }
        }
        if (!IsFound)
        {
            for (int i = 0; i < InvertoryDatas.Count; i++)
            {
                if(InvertoryDatas[i].ItemData == null)
                {
                    InvertoryDatas[i].ItemData = itemdata;
                    return;
                }
            }
        }
    }
}
