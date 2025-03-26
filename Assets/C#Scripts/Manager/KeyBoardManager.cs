using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardManager : SingleTons<KeyBoardManager>
{
    public bool GetKeyDown_Space()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
