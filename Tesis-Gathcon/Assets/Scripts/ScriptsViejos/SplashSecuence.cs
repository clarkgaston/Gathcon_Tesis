using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSecuence : MonoBehaviour
{
    public float transitionTime = 5f;

    public static int sceneNumber;

    void Start()
    {
        if (sceneNumber == 0)
        {
            StartCoroutine(ToStartScene());
        }
    }

    IEnumerator ToStartScene()
    {
        yield return new WaitForSeconds(transitionTime);

        sceneNumber = 1;
        SceneManager.LoadScene(1);
    }
}
