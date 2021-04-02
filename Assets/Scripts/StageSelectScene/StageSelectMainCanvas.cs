using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectMainCanvas : MonoBehaviour
{
    private string NextScene { get; set; }
    [SerializeField]
    private MainGameProgress MainGameProgress;
    [SerializeField]
    private Animator SceneFadeAnimator;
    [SerializeField]
    private Button Stage1Button;

    private void Awake()
    {
        this.NextScene = "PlayScene";
    }

    public void OnClickSelectStage(Button clickedButton)
    {
        this.MainGameProgress.CurrentStage = this.GetSelectedStage(clickedButton);
        SceneFadeAnimator.SetTrigger("TriggerFadeOut");
    }

    private GameStage GetSelectedStage(Button clickedButton)
    {
        if (clickedButton == this.Stage1Button)
        {
            return GameStage.Stage1;
        }
        else
        {
            return GameStage.AtTitle;
        }
    }
}
