using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        collision.GetComponent<CarMover>()._force *= 0.9f;
        Debug.Log("nice");
    }
    void Update()
    {
        
    }
}
