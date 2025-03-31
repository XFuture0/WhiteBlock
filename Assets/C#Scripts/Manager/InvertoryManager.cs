using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InvertoryManager : SingleTons<InvertoryManager>
{
    public Invertory HatBag;
    public Invertory WeaponBag;
    public Invertory ArmourBag;

    private void OnEnable()
    {
        LoadInvertoryData();
        DataManager.Instance.Save(HatBag, "HatBag");
        DataManager.Instance.Save(WeaponBag, "WeaponBag");
        DataManager.Instance.Save(ArmourBag, "ArmourBag");
    }
    public void AddItem(ItemData itemData)
    {
        switch(itemData.ItemType)
            {
                case ItemType.Hat:
                    HatBag.AddItem(itemData);
                    DataManager.Instance.Save(HatBag, "HatBag");
                break;
                case ItemType.Weapon:
                    break;
                case ItemType.Armour:
                    break;
                case ItemType.others:
                    break;
            }
    }
    private void LoadInvertoryData()
    {
        if(PlayerPrefs.HasKey("HatBag"))
        {
            DataManager.Instance.Load(HatBag, "HatBag");
        }
        if (PlayerPrefs.HasKey("WeaponBag"))
        {
            DataManager.Instance.Load(WeaponBag, "WeaponBag");
        }
        if (PlayerPrefs.HasKey("ArmourBag"))
        {
            DataManager.Instance.Load(ArmourBag, "ArmourBag");
        }
    }
}
