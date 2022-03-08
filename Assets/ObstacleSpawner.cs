using UnityEngine;
public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] ObstacleObject;
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0, 2);
    }
    void SpawnObstacle()
    {
        int randomNumber = Random.Range(0, 4);
        Instantiate(ObstacleObject[randomNumber], transform.position, Quaternion.identity);
    }
}
