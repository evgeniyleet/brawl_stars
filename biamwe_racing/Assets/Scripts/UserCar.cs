using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCar : MonoBehaviour
{
    public CarMover Car;

    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Car.Accelerate();
        }
        if (Input.GetKey(KeyCode.S))
        {
            Car.UnAccelerate();
        }
        if (Input.GetKey(KeyCode.D))
        {
            Car.RotateRight();
        }
        if (Input.GetKey(KeyCode.A))
        {
            Car.RotateLeft();
        }
    }
}
