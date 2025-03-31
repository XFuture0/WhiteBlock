using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsCanvs : MonoBehaviour
{
    public Image PlayerHealthLine;
    public Text CoinCountText;
    [Header("ÊÂ¼þ¼àÌý")]
    public VoidEvenSO GetCoinEvent;
    private void Start()
    {
        LoadCoinCount();
    }
    private void Update()
    {
        RefreshPlayerHealthLine();
    }
    private void OnEnable()
    {
        GetCoinEvent.OnEventRaised += OnGetCoinCount;
    }
    private void OnGetCoinCount()
    {
        GameManager.Instance.PlayerStats.PlayerStats_Temp.CoinCount++;
        CoinCountText.text = GameManager.Instance.PlayerStats.PlayerStats_Temp.CoinCount.ToString().PadLeft(4,'0');
        DataManager.Instance.Save(GameManager.Instance.PlayerStats.PlayerStats_Temp, "PlayerStats");
    }
    private void RefreshPlayerHealthLine()
    {
        var healthLineLevel = GameManager.Instance.PlayerStats.PlayerStats_Temp.NowHealth / GameManager.Instance.PlayerStats.PlayerStats_Temp.MaxHealth;
        PlayerHealthLine.transform.localScale = new Vector3(healthLineLevel * 1.5f, 1, 1);
    }
    private void LoadCoinCount()
    {
        CoinCountText.text = GameManager.Instance.PlayerStats.PlayerStats_Temp.CoinCount.ToString().PadLeft(4,'0');
    }
}
