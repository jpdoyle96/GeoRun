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

    internal bool isLeftPressed { get; private set; }
    internal bool isRightPressed { get; private set; }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            isLeftPressed = true;
        }
        else
        {
            isLeftPressed = false;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            isRightPressed = true;
        }
        else
        {
            isRightPressed = false;
        }
    }
}
