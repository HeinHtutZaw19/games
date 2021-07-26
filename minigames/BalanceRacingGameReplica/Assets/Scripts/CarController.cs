using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 1500f;
    public WheelJoint2D wheel_back;
    private float movement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Vertical") * speed;
    }

    private void FixedUpdate()
    {
        if(movement == 0f)
        {
            wheel_back.useMotor = false;
        }
        else
        {
            wheel_back.useMotor = true;
            JointMotor2D mtr = new JointMotor2D { motorSpeed = movement, maxMotorTorque = wheel_back.motor.maxMotorTorque };
            wheel_back.motor = mtr;
        }
    }
}
