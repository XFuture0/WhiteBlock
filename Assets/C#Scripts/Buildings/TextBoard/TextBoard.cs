using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class TextBoard : MonoBehaviour
{
    [TextArea]
    public string TextBoardText;
    public Canvas TextBoardCanvs;
    private List<string> TextList = new List<string>();
    private bool PlayerCome;
    private bool IsOpen;
    private void Awake()
    {
        CutText();
    }
    private void Update()
    {
        CheckKey();
        CloseCanvs();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerCome = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerCome = false;
        }
    }
    private void CutText()
    {
        var texts = TextBoardText.Split('\n');
        foreach(var text in texts)
        {
            TextList.Add(text);
        }
    }
    private void CloseCanvs()
    {
        if (Input.anyKey && IsOpen)
        {
            IsOpen = false;
            TextBoardCanvs.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
    private void CheckKey()
    {
        if((KeyBoardManager.Instance.GetKeyDown_W() || KeyBoardManager.Instance.GetKeyDown_S()) && PlayerCome && !IsOpen)
        {
            KeyBoardManager.Instance.StopAnyKey = true;
            TextBoardCanvs.transform.GetChild(0).gameObject.SetActive(true);
            StartCoroutine(PrintText());
        }
    }
    private IEnumerator PrintText()
    {
        TextBoardCanvs.transform.GetChild(0).gameObject.SetActive(true);
        TextBoardCanvs.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "";
        for (int i = 0; i < TextList.Count; i++)
        {
            TextBoardCanvs.transform.GetChild(0).GetChild(0).GetComponent<Text>().text += TextList[i] + "\n";
            yield return new WaitForSeconds(0.8f);
        }
        IsOpen = true;
        KeyBoardManager.Instance.StopAnyKey = false;
    }
}
