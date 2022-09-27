using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Store a reference to all the other player scripts
    [field: SerializeField]
    internal PlayerInput PlayerInput { get; private set; }

    [field: SerializeField]
    internal PlayerMovement PlayerMovement { get; private set; }

    [field: SerializeField]
    internal PlayerCollision PlayerCollision { get; private set; }

    internal Rigidbody Rigidbody { get; private set; }
    internal Transform Transform { get; private set; }
    
    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Transform = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
