using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherScript : MonoBehaviour
{
    private bool _isLoading;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void LoadNextScene(int num)
    {
        StartCoroutine(LoadSceneRoutine(num));
    }

    private IEnumerator LoadSceneRoutine(int num)
    {
        if(_isLoading)
            yield break;

        _isLoading = true;
        
        AsyncOperation sceneLoad = SceneManager.LoadSceneAsync(num);
        
        sceneLoad.allowSceneActivation = false;

        yield return StartCoroutine(LoadingScreenScript.Instance.ShowRoutine());

        sceneLoad.allowSceneActivation = true;
        
        yield return StartCoroutine(LoadingScreenScript.Instance.FadeRoutine());
        
        _isLoading = false;
        

    }
}
