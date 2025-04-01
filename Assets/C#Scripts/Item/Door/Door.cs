using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool IsTouch;
    public SceneData NowScene;
    public SceneData NextScene;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !IsTouch)
        {
            IsTouch = true;
            SceneChangeManager.Instance.ChangeScene(NowScene,NextScene);
        }
    }
}
