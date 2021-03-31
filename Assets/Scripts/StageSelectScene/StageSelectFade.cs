using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectFade : MonoBehaviour
{
    private StageSelectBehindScene BehindScene;

    private void Awake()
    {
        this.BehindScene = GameObject.Find("/BehindScene").GetComponent<StageSelectBehindScene>();
    }

    public void OnFadeOutFinished()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
