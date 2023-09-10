using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 30f;
    private Transform target;

    private int WaypointIndex = 0;
  

     void Start() {
         target = WayPoints.points[0];
    
    }

     void Update() {

        Vector3 dir = target.position - transform.position;

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

    if(Vector3.Distance(transform.position, target.position)<= 0.4f){
           GetNextWaypoint();
    }
        
    }

    void GetNextWaypoint(){

        if (WaypointIndex>= WayPoints.points.Length-1){
            
            Destroy(gameObject);
            
           return;
        }
       WaypointIndex++;
       target = WayPoints.points[WaypointIndex];
    }


}
