using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float maxVelocity;
    [SerializeField] float accel;
    private float currentVel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move left
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.RightArrow)) {
            
        }
        // Move right
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && Input.GetKeyUp(KeyCode.A) && Input.GetKeyUp(KeyCode.LeftArrow)) {
            
        }
    }
}
