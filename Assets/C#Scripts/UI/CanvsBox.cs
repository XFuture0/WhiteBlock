using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvsBox : MonoBehaviour
{
    public GameObject PlayerCanvs;
    public GameObject PlayerStatsCanvs;
    private void Update()
    {
        OpenPlayerCanvs();
    }
    private void OpenPlayerCanvs()
    {
        if (KeyBoardManager.Instance.GetKeyDown_Tab())
        {
            if (PlayerCanvs.activeSelf)
            {
                PlayerCanvs.SetActive(false);
                KeyBoardManager.Instance.StopMoveKey = false;
            }
            else
            {
                PlayerCanvs.SetActive(true);
                KeyBoardManager.Instance.StopMoveKey = true;
            }
        }
    }
}
