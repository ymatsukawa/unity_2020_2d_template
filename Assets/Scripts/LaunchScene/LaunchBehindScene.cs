using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchBehindScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("LoadNextSceneDelay", 3f);
    }

    void Update()
    { }

    IEnumerator LoadNextSceneDelay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("TitleScene");
    }
}
