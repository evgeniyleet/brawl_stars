using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCar : MonoBehaviour
{
    public CarMover Car;
    private bool _isBoosted;
    
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
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Car.Speed *= 2f;
        //    _isBoosted = true;
        //}
        //if(!_isBoosted)
        //{
        //    Car._force = Vector3.Lerp(Car._force, Vector3.zero, Time.deltaTime);
        //}
    }
}
