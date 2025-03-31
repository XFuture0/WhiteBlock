using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardManager : SingleTons<KeyBoardManager>
{
    public bool StopAnyKey;
    public bool StopMoveKey;
    public bool GetKeyDown_Space()
    {
        if (!StopAnyKey && !StopMoveKey)
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
        return false;
    }
    public bool GetKeyDown_W()
    {
        if (!StopAnyKey && !StopMoveKey)
        {
            return Input.GetKeyDown(KeyCode.W);
        }
        return false;
    }
    public bool GetKeyDown_S()
    {
        if (!StopAnyKey && !StopMoveKey)
        {
            return Input.GetKeyDown(KeyCode.S);
        }
        return false;
    }
    public bool GetKey_S()
    {
        if (!StopAnyKey && !StopMoveKey)
        {
            return Input.GetKey(KeyCode.S);
        }
        return false;
    }
    public float GetHorizontalRaw()
    {
        if (!StopAnyKey && !StopMoveKey)
        {
            return Input.GetAxisRaw("Horizontal");
        }
        return 0f;
    }
    public bool GetKeyDown_J()
    {
        if (!StopAnyKey && !StopMoveKey)
        {
            return Input.GetKeyDown(KeyCode.J);
        }
        return false;
    }
    public bool GetKeyDown_Tab()
    {
        if (!StopAnyKey)
        {
            return Input.GetKeyDown(KeyCode.Tab);
        }
        return false;
    }
}
