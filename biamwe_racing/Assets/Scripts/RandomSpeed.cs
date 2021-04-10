using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpeed : MonoBehaviour
{
    public CarMover Car;

    void Start()
    {
        Car.Speed = Random.Range(10f, 100f);
        Debug.Log("speed = "+Car.Speed);
    }
}
