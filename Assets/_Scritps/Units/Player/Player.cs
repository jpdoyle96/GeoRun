using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Store a reference to all the other player scripts
    [SerializeField]
    internal PlayerInput PlayerInput { get; private set; }

    [SerializeField]
    internal PlayerMovement PlayerMovement { get; private set; }

    [SerializeField]
    internal PlayerCollision PlayerCollision { get; private set; }

    internal Rigidbody Rigidbody { get; private set; }
    internal Transform Transform { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
