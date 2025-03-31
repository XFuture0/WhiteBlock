using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InvertoryManager : SingleTons<InvertoryManager>
{
    public Invertory HatBag;
    public Invertory WeaponBag;
    public Invertory ArmourBag;
    public void AddItem(ItemData itemData)
    {
        switch(itemData.ItemType)
            {
                case ItemType.Hat:
                    HatBag.AddItem(itemData);
                    break;
                case ItemType.Weapon:
                    break;
                case ItemType.Armour:
                    break;
                case ItemType.others:
                    break;
            }
    }
}
