﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
/// <summary>
/// 
/// </summary>
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.CompareTag("Ball")){
			Destroy(this.gameObject);
		}
	}
}