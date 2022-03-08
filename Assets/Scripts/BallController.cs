using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float levelSpeed = 0.06f;
    private void Start()
    {
        Destroy(gameObject, 2);
    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * levelSpeed);
    }
}
