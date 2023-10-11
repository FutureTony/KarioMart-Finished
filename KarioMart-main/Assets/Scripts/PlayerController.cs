using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]  Rigidbody2D rb;  
    [SerializeField]  InputAction playerController;
    public int lapNumber;
    public int checkpointIndex;
    public float maxSpeed = 75;
    float turnDirection = 0f;
    public float movespeed = 50;
    // could make in separate script but i couldnt get it to work so ill do it here
   
    void Start()
    {
        playerController.Enable();
        lapNumber = 1;
        checkpointIndex = 0;

    }
    private void OnDisable()
    {
        playerController.Disable();
    }
    private void RotatePlayer(Vector3 rotationVector)
    {
        transform.Rotate(rotationVector * Time.deltaTime * 100);
    }
    private void Accelerate()
    {
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(transform.right * movespeed * Time.deltaTime);
        } 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        turnDirection = playerController.ReadValue<float>();
        // use the possetive value and negative value of the input to turn the car 
        Accelerate();
        // Debug.Log(transform.right * movespeed * Time.deltaTime);
        Vector3 rotationVector = new Vector3(0f, 0f, turnDirection);
        RotatePlayer(rotationVector);
    }
}
