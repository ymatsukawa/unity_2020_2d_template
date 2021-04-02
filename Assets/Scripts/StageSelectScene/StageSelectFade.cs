using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectFade : MonoBehaviour
{
    public void OnFadeOutFinished()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
