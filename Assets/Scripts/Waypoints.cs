using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    private WaveConfig waveConfig;
    private List<Transform> waypoints;
    //private Transform[] waypoints;
    int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }
    
    //Method for the transform to move towards the 'waypoints'
    void Move()
    {
        Vector3 targetPosition = waypoints[waypointIndex].transform.position;
        float moveSpeed = waveConfig.GetMoveSpeed() * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition,
            moveSpeed);

        if (transform.position == targetPosition)
        {
            waypointIndex ++;
        }

        if (waypointIndex == waypoints.Count)
        {
            Destroy(gameObject);
        }
    }
    
}
