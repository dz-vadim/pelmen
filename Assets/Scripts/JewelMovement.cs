using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelMovement : MonoBehaviour
{
    private float levelSpeed = 0.06f;

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * levelSpeed);
    }

    private void Start()
    {
        Destroy(gameObject, 8f);
    }
}
