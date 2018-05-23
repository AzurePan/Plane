using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    [SerializeField]
    public GameObject colum;
    private float coldDown = 3f;
    private float nextSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + coldDown;
            Vector2 spawnPosition = transform.position;
            spawnPosition.y = Random.Range(2f, -4);
            Instantiate(colum, spawnPosition, transform.rotation);
        }	
	}
}
