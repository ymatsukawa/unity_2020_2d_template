using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMainCanvas : MonoBehaviour
{
    [SerializeField]
    private Animator OptionShowAnimator;
    private string NextScene;

    private void Awake()
    {
        this.NextScene = "StageSelectScene";
    }
    #region UI - MainCanvas
    public void OnClickNewGameButton()
    {
        SceneManager.LoadScene(this.NextScene);
    }

    public void OnClickLoadGameButton()
    {
        SceneManager.LoadScene(this.NextScene);
    }

    public void OnClickOptionButton()
    {
        this.OptionShowAnimator.SetTrigger("TriggerOptionShow");
    }

    public void OnClickExitButton()
    {
        Application.Quit();
    }
    #endregion
}
