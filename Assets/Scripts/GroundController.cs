using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private float levelSpeed = 0.06f;
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * levelSpeed);
        if (transform.position.x < -4f) 
        {
            transform.position = Vector3.zero;
        }
    }
}
