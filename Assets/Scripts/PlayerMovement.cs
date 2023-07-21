using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    Vector3 velocity;
    public float gravity = -9.81f;

    

    float rate = 1f;
    float last = 0.0f;



    void Start()
    {
        
    }

    
    void Update()
    {
        
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move=transform.right*x + transform.forward*z;
        controller.Move(move*speed*Time.deltaTime); 

        velocity.y += gravity*Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);

        if (Input.GetButtonDown("Jump")&& Time.time > rate + last)
        {

            velocity.y = 4.5f;
            last = Time.time;
        }
    }
}
