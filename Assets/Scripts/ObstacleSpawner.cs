using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float minY;
    public float maxY;
    public float distance;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Obstacle")
        {
            float obstacleY = Random.Range(minY, maxY);

            Vector3 spawnPosition = new Vector3(transform.position.x + distance, obstacleY, 0);

            col.gameObject.transform.position = spawnPosition;
        }
    }
}