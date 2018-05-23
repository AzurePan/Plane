using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UI : MonoBehaviour {
    [SerializeField]
    private Text num;
    [SerializeField]
    private GameObject gameOver;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        num.text = Convert.ToString(GameManager.score);
        if (!GameManager.isActive)
        {
            gameOver.SetActive(true);
        }
    }
}

