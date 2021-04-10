using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class CarMover : MonoBehaviour
{
    public Transform SelfTransform;
    public Tilemap Map;
    public TileBase GroundTile;

    private Vector3 _force;
    private bool _isAccelerated;


    public void Accelerate()
    {
        _force += (SelfTransform.up * Time.deltaTime) * 0.05f;
        _isAccelerated = true;
    }
    public void UnAccelerate()
    {
        _force += (SelfTransform.up * Time.deltaTime) * -0.05f;
        _isAccelerated = true;
    }

    public void RotateRight()
    {
        SelfTransform.Rotate(0, 0, -2);
    }

    public void RotateLeft()
    {
        SelfTransform.Rotate(0, 0, 2);
    }

    void LateUpdate()
    {
        if(!_isAccelerated)
        {
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
        }

        if (GroundTile == Map.GetTile(new Vector3Int((int)SelfTransform.position.x,
            (int)SelfTransform.position.y,
            (int)SelfTransform.position.z)))
        {
             _force *= 0.9f;
        }
        
        SelfTransform.position += _force;
        

        SelfTransform.position += _force;
        _isAccelerated = false;
    }
}
