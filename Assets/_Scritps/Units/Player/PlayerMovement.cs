using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Player script
    [SerializeField]
    private Player _playerScript;

    [SerializeField]
    internal float MaxSpeed { get; private set; }
    [SerializeField]
    internal float Acceleration { get; private set; }
    [SerializeField]
    internal float Deceleration { get; private set; }
    [SerializeField]
    internal float ClampX { get; private set; }

    // Update is called once per frame
    void Update()
    {
        // Check input manager for button press state
        if (_playerScript.PlayerInput.isLeftPressed && !_playerScript.PlayerInput.isRightPressed)
        {
            MovePlayerLeft();
        }
        else if (_playerScript.PlayerInput.isRightPressed && !_playerScript.PlayerInput.isLeftPressed)
        {
            MovePlayerRight();
        }
        else
        {
            StopMovement();
        }
        if (Mathf.Abs(_playerScript.Transform.position.x) > ClampX)
        {
            ClampPosition();
        }
    }

    private void MovePlayerLeft()
    {
        
    }

    private void MovePlayerRight()
    {

    }

    private void StopMovement()
    {

    }

    private void ClampPosition()
    {

    }
}
