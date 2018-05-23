using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum : MonoBehaviour {
    [SerializeField]
    private float speed = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.isActive) {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x < -7.8f)
            {
                Destroy(this.gameObject);
            }
        }
	}

    private void OnTriggerExit2D (Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.score += 1;
        }   
    }
}
