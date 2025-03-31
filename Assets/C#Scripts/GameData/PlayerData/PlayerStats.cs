using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New PlayerData", menuName = "Data/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public float MaxHealth;
    public float NowHealth;
    public float AttackPower;
    public int CoinCount;
}
