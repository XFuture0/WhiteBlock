using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCanvs : MonoBehaviour
{
    public Button LeftButton;   
    public Button RightButton;
    public Button ReturnButton;
    public GameObject BagBox;
    private int BagIndex = 0;
    private void Awake()
    {
        LeftButton.onClick.AddListener(LeftChangeBag);
        RightButton.onClick.AddListener(RightChangeBag);
        ReturnButton.onClick.AddListener(ReturnGame);
    }
    private void LeftChangeBag()
    {
        if(BagIndex - 1 >= 0)
        {
            BagBox.transform.GetChild(BagIndex).gameObject.SetActive(false);
            BagIndex--;
            BagBox.transform.GetChild(BagIndex).gameObject.SetActive(true);
        }
    }
    private void RightChangeBag()
    {
        if(BagIndex + 1 < BagBox.transform.childCount)
        {
            BagBox.transform.GetChild(BagIndex).gameObject.SetActive(false);
            BagIndex++;
            BagBox.transform.GetChild(BagIndex).gameObject.SetActive(true);
        }
    }
    private void ReturnGame()
    {
        KeyBoardManager.Instance.StopAnyKey = false;
        gameObject.SetActive(false);
    }
}
