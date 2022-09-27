using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player input script
/// </summary>
public class PlayerInput : MonoBehaviour
{
    // Player script
    [SerializeField]
    private Player _playerScript;

    internal bool IsLeftPressed { get; private set; }
    internal bool IsRightPressed { get; private set; }

    void Start()
    {
        IsLeftPressed = false;
        IsRightPressed = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            print("Left Pressed");
            IsLeftPressed = true;
        }
        else
        {
            IsLeftPressed = false;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            print("Right pressed");
            IsRightPressed = true;
        }
        else
        {
            IsRightPressed = false;
        }
    }
}
