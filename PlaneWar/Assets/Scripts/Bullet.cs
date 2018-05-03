using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField]
    private float speed = 10f;
    private Vector3 direction = Vector3.up;
	
	void Update () {
        transform.Translate(direction * speed * Time.deltaTime);	
	}
}
