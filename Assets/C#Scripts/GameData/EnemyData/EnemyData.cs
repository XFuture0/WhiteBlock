using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New PlayerData",menuName ="Data/EnemyData")]
public class EnemyData : ScriptableObject
{
    public float MaxHealth;
    public float NowHealth;
    public float AttackPower;
}
