using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayClockHand : MonoBehaviour
{
    [SerializeField]
    private HandClockStatus HandClockStatus;

    private void Awake()
    {
        this.HandClockStatus.Initialize();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.HandClockStatus.SwitchRotation();
        }
        this.gameObject.transform.Rotate(new Vector3(0, 0, this.HandClockStatus.RotationSpeed));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.HandClockStatus.SwitchRotation();
    }
}
