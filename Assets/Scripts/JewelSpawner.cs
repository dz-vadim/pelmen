using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject JewelObject;

    void Start()
    {
        InvokeRepeating(nameof(SpawnJewel), 0, 3);
    }

    void SpawnJewel()
    {
        Instantiate(JewelObject, transform.position, Quaternion.identity);
    }
}
