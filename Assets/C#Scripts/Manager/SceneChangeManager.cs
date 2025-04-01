using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeManager : SingleTons<SceneChangeManager>
{
    private SceneData nowScene;
    private SceneData nextScene;
    public void ChangeScene(SceneData NowScene, SceneData NextScene)
    {
        nowScene = NowScene;
        nextScene = NextScene;
        StartCoroutine(LoadScene());
    }
    private IEnumerator LoadScene()
    {
        yield return SceneManager.UnloadSceneAsync(nowScene.SceneName);
        yield return SceneManager.LoadSceneAsync(nextScene.SceneIndex,LoadSceneMode.Additive);
    }
}
