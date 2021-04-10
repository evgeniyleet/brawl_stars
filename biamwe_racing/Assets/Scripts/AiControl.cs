using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiControl : MonoBehaviour
{
    public Transform[] Waypoints;
    public Transform SelfTransform;
    public CarMover Car;
    private int _currentPoint;


    void Update()
    {
        Transform current = Waypoints[_currentPoint];
        Debug.DrawLine(SelfTransform.position, current.position, Color.red);

        Vector3 direction = SelfTransform.position - current.position;
        float angel = Vector3.Dot(direction, -SelfTransform.right);

        Debug.Log(angel);
        if (angel > 0)
        {
            Car.RotateRight();
        }
        else if (angel == 0)
        {
        }
        else
        {
            Car.RotateLeft();
        }

        if (angel < 0.2f && angel > -0.2f)
        {
            Car.Accelerate();
        }
        Debug.Log(Vector3.Distance(SelfTransform.position, current.position));
        if (Vector3.Distance(SelfTransform.position, current.position) < 2.9f)
        {
            _currentPoint++;
            if (_currentPoint > Waypoints.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
