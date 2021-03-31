using UnityEngine;

[CreateAssetMenu(fileName = "MainGameProgress", menuName = "ScriptableObject/MainGameProgress")]
public class MainGameProgress : ScriptableObject
{
    public bool IsStage1Cleared;
    public bool IsStage2Cleared;
    public bool IsStage3Cleared;
    public bool IsStage4Cleared;
    public bool IsStage5Cleared;
    public bool IsStage6Cleared;
    public bool IsStage7Cleared;
    public bool IsStage8Cleared;
    public bool IsStage9Cleared;
    public bool IsStage10Cleared;

    private void OnEnable()
    {
        this.IsStage1Cleared = false;
        this.IsStage2Cleared = false;
        this.IsStage3Cleared = false;
        this.IsStage4Cleared = false;
        this.IsStage5Cleared = false;
        this.IsStage6Cleared = false;
        this.IsStage7Cleared = false;
        this.IsStage8Cleared = false;
        this.IsStage9Cleared = false;
        this.IsStage10Cleared = false;
    }
}
