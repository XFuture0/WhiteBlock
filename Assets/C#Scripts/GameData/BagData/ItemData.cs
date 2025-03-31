using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New ItemData",menuName ="Data/New ItemData")]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public ItemType ItemType;
    public Sprite ItemImage;
}
