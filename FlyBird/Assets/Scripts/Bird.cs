using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    [SerializeField]
    private float fouce = 200f;
    Rigidbody2D bird;
    

	// Use this for initialization
	void Start () {
        bird = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.isActive)
        {
            if (Input.GetMouseButtonDown(0))
            {
                bird.AddForce(Vector2.up * fouce);
            }
        }
    }
}
