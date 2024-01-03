using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] public float speed = 2f;

    private Transform target;
    private int wavepointIndex = 0;
    private WaveSpawner waveSpawner;
    Player player;



    void Start()
    {
        target = Waypoints.points[0];
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void EndPath()
    {
        WaveSpawner waveSpawner = FindObjectOfType<WaveSpawner>();
        waveSpawner.remainingEnemies--;
        Destroy(gameObject);
        player.TakeDamage(20);
    }
    /* void ReduceLives()
     {
         player.TakeDamage(20);
         // Debug.Log("Health: " + player.currentHealth);
     }
 */
}
