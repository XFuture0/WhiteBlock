using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
[CreateAssetMenu(fileName = "New Scene Data", menuName = "Data/Scene Data")]
public class SceneData : ScriptableObject
{
    public string SceneName;
    public int SceneIndex;
}
