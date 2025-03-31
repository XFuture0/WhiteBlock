using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [HideInInspector]public bool IsProtected;
    public PlayerStats PlayerStats;
    public PlayerStats PlayerStats_Temp;
    public EnemyData enemyData;
    public EnemyData enemyData_Temp;
    private void Awake()
    {
        if(PlayerStats != null)
        {
            PlayerStats_Temp = Instantiate(PlayerStats);
        }
        if(enemyData != null)
        {
            enemyData_Temp = Instantiate(enemyData);
        }
    }
    public void Attack(CharacterStats Attacker, CharacterStats Defender)
    {
        if (!Defender.IsProtected && Attacker.gameObject.tag == "Enemy")
        {
            Defender.PlayerStats_Temp.NowHealth -= Attacker.enemyData.AttackPower;
            if(Defender.PlayerStats_Temp.NowHealth <= 0)
            {
                Defender.PlayerStats_Temp.NowHealth = 0;
                //TODO:ËÀÍö
            }
        }
        if(!Defender.IsProtected && Attacker.gameObject.tag == "Player")
        {
            Defender.enemyData_Temp.NowHealth -= Attacker.PlayerStats.AttackPower;
            if(Defender.enemyData_Temp.NowHealth <= 0)
            {
                Defender.enemyData_Temp.NowHealth = 0;
            }
        }
    }
}
