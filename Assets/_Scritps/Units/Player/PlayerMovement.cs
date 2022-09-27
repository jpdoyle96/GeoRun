using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Player script
    [SerializeField]
    private Player _playerScript;

    [field: SerializeField]
    internal float MaxSpeed { get; private set; }
    [field: SerializeField]
    internal float Acceleration { get; private set; }
    [field: SerializeField]
    internal float Deceleration { get; private set; }
    [field: SerializeField]
    internal float DecelerateStop { get; private set; }
    [field: SerializeField]
    internal float ClampX { get; private set; }

    void Update()
    {
        // Check input manager for button press state
        if (_playerScript.PlayerInput.IsLeftPressed && !_playerScript.PlayerInput.IsRightPressed)
        {
            print("Moving left");
            MovePlayerLeft();
        }
        else if (_playerScript.PlayerInput.IsRightPressed && !_playerScript.PlayerInput.IsLeftPressed)
        {
            print("Moving right");
            MovePlayerRight();
        }
        else
        {
            print("Stopping movement");
            StopMovement();
        }
        if (Mathf.Abs(_playerScript.Transform.position.x) > ClampX)
        {
            print("Clamping position");
            ClampPosition();
        }
    }

    private void MovePlayerLeft()
    {
        if (Mathf.Sign(_playerScript.Rigidbody.velocity.x) == 1.0f)
        {
            _playerScript.Rigidbody.velocity = new Vector3(0, 0, 0);
        }
        _playerScript.Rigidbody.velocity = new Vector3(Mathf.Clamp((_playerScript.Rigidbody.velocity.x - Acceleration * Time.deltaTime), -MaxSpeed, MaxSpeed), 0);

    }

    private void MovePlayerRight()
    {
        if (Mathf.Sign(_playerScript.Rigidbody.velocity.x) == -1.0f)
        {
            _playerScript.Rigidbody.velocity = new Vector3(0, 0, 0);
        }
        _playerScript.Rigidbody.velocity = new Vector3(Mathf.Clamp((_playerScript.Rigidbody.velocity.x + Acceleration * Time.deltaTime), -MaxSpeed, MaxSpeed), 0);
    }

    private void StopMovement()
    {
        if (_playerScript.Rigidbody.velocity.x > -DecelerateStop && _playerScript.Rigidbody.velocity.x < DecelerateStop)
        {
            _playerScript.Rigidbody.velocity = new Vector3(0, 0, 0);
        }
        else
        {
            _playerScript.Rigidbody.velocity = new Vector3(_playerScript.Rigidbody.velocity.x - Mathf.Sign(_playerScript.Rigidbody.velocity.x) * Deceleration * Time.deltaTime, 0, 0);
        }
        
    }

    private void ClampPosition()
    {
        _playerScript.Transform.position = new Vector3(Mathf.Clamp(_playerScript.Transform.position.x, -ClampX, ClampX), 0);
        _playerScript.Rigidbody.MovePosition(_playerScript.Transform.position);
        _playerScript.Rigidbody.velocity = new Vector3(0, 0, 0);
    }
}
