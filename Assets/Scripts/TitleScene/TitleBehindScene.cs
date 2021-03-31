using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBehindScene : MonoBehaviour
{
    private string NextScene;

    private void Awake()
    {
        this.NextScene = "StageSelectScene";
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClickNewGameButton()
    {
        SceneManager.LoadScene(this.NextScene);
    }

    public void OnClickLoadGameButton()
    {
        SceneManager.LoadScene(this.NextScene);
    }

    public void OnClickConfigButton()
    {
        Debug.Log("OnClick Config");
    }

    public void OnClickExitButton()
    {
        Debug.Log("OnClick Exit");
    }
}
