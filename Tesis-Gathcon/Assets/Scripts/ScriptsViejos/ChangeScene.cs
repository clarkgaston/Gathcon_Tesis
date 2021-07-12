using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public float transitionTime = 1f;

    IEnumerator LoadScene(int sceneIndex)
    {
        Cursor.visible = false;

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneIndex);
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadBackScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 1));
    }

    public void LoadSplashScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 5));
    }
}
