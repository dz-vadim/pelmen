using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController1 : MonoBehaviour
{
    private float moveSpeed;
    private float levelSpeed =0.06f;
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * levelSpeed);
    }
}
