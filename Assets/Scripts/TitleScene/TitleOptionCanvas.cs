using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleOptionCanvas : MonoBehaviour
{
    [SerializeField]
    private Animator OptionShowAnimator;

    public void OnClickSave()
    {
        OptionShowAnimator.SetTrigger("TriggerOptionClose");
    }
}
