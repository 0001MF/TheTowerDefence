using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
   public Transform EnemyPrefab;
   public float Timebetweenwaves = 3f;
   private  float countdown = 2f;
   private float WaveNumber = 0;
   public Transform SpawnPoint;

  void Update() {
    
    if (countdown<= 0f){

       StartCoroutine(SpawnWave());
        countdown = Timebetweenwaves;
    }

     countdown -= Time.deltaTime;
 }

      IEnumerator SpawnWave(){
      
       for (int i = 0; i < WaveNumber; i++)
       {
               SpawnEnemy();
               yield return new WaitForSeconds(0.5f);
       }
            WaveNumber++;

     }
      void SpawnEnemy(){

        Instantiate(EnemyPrefab, SpawnPoint.position, SpawnPoint.rotation);


      }

}
