using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayClockHand : MonoBehaviour
{
    private float RotationSpeed;

    private void Awake()
    {
        this.RotationSpeed = 5f;
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
            this.RotationSpeed = -this.RotationSpeed;
        }
        this.gameObject.transform.Rotate(new Vector3(0, 0, this.RotationSpeed));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.collider.name + " collisioned");
    }

}
