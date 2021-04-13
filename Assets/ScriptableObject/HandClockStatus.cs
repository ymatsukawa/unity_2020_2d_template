using UnityEngine;

[CreateAssetMenu(fileName = "HandClockStatus", menuName = "ScriptableObject/HandClockStatus")]
public class HandClockStatus : ScriptableObject
{
    public float RotationSpeed;
    private bool IsClockwise;

    public void SwitchRotation()
    {
        this.IsClockwise = !this.IsClockwise;
        this.RotationSpeed = -this.RotationSpeed;
    }

    public void OnEnable()
    {
        this.Initialize();
    }

    public void Initialize()
    {
        this.IsClockwise = true;
        this.RotationSpeed = 1f;
    }
}
