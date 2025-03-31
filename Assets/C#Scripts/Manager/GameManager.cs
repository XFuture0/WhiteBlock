using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTons<GameManager>
{
    public CharacterStats PlayerStats;
    private void Start()
    {
        PlayerStats = GameObject.Find("Player").GetComponent<CharacterStats>();
    }
}
