using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float spawn_time;
    public float minX = -1f;
    public float maxY = 1f;



    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn_obstacle), spawn_time, spawn_time);
    }

    private void OnDisable()
    { //stop spawning
        CancelInvoke(nameof(Spawn_obstacle));
    }
    private void Spawn_obstacle()
    {
        GameObject Obstacle = Instantiate(prefab, transform.position, Quaternion.identity);
        Obstacle.transform.position += Vector3.up * Random.Range(minX, maxY);
     
    }
}
