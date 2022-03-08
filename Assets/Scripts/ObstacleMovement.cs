using UnityEngine;
public class ObstacleMovement : MonoBehaviour
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
