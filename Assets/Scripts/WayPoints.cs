using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public static Transform[] points;


    void  Awake() {
    
      points = new Transform[transform.childCount];

       for( int i = 0 ; i< points.Length; i++){

   /// this below line of code return the transform child by index..     
        points[i] = transform.GetChild(i);


       }

        

   }

   
    



}
