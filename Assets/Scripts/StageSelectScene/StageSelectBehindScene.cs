using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectBehindScene : MonoBehaviour
{
    public string NextScene { get; private set; }
    [SerializeField]
    private Animator SceneFadeAnimator;

    private void Awake()
    {
        this.NextScene = "PlayScene";
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnClickSelectStage()
    {
        SceneFadeAnimator.SetTrigger("TriggerFadeOut");
    }
}
