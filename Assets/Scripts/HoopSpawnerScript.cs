using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopSpawnerScript : MonoBehaviour {

    public GameObject hoop;
    float randx;
    Vector2 whereToSpawn;
   // public float spawnRate = 2f;
   // float nextSpawn = 0.0f;
	
	void Start () {
		
	}
	
	
	void Update () {
		
        if(GameObject.FindGameObjectWithTag("Board")== null)
        {
            randx = Random.Range(-320f, 286f);
            whereToSpawn = new Vector2(randx, transform.position.y);
            hoop = (GameObject)Instantiate(hoop, whereToSpawn, Quaternion.identity);
            
        }
	}
}
