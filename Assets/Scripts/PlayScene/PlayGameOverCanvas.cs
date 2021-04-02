using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameOverCanvas : MonoBehaviour
{
    [SerializeField]
    private Animator GameOverAnimator;
    private uint OverCount;

    private void Awake()
    {
        this.OverCount = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.OverCount++;
            if (this.OverCount > 3)
            {
                Debug.Log("Count is Over");
                this.OverCount = 0;
                GameOverAnimator.SetTrigger("TriggerGameOverShow");
            }
        }
    }

    public void OnClickRetry()
    {
        this.GameOverAnimator.SetTrigger("TriggerGameOverRetry");
    }

    public void OnClickBack()
    {
        this.GameOverAnimator.SetTrigger("TriggerGameOverEnd");
    }

    public void OnGameOverRetry()
    {
        Debug.Log("OnGameOverRetry");
    }

    public void OnGameOverEnd()
    {
        Debug.Log("OnGameOverEnd");
        SceneManager.LoadScene("StageSelectScene");
    }
}
