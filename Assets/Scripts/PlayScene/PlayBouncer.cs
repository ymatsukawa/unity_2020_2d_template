using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBouncer : MonoBehaviour
{
    [SerializeField]
    private HandClockStatus HandClockStatus;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if(other.name.Equals("BounceWall"))
        {
            this.HandClockStatus.SwitchRotation();
        }
    }
}
