using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy enemy;

    void Start()
    {
        Instantiate(enemy, gameObject.transform);
    }

    void Update()
    {
        
    }
}
