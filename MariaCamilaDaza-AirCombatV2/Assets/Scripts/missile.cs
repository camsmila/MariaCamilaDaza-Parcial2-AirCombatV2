﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (0.0f, 2.0f, 0.0f);
	}



	void OnCollisionEnter(Collision collision) {

		if (collision.collider.gameObject.tag == "MarsAlien") {

			GameObject explosion = GameObject.Instantiate(Resources.Load ("Prefabs/MarsExplosion") as GameObject);

			explosion.transform.position = collision.collider.gameObject.transform.position; 

			Destroy (collision.collider.gameObject); 

			Destroy (this.gameObject);

		}

		if (collision.collider.gameObject.tag == "JupiterAlien") {

			GameObject explosion = GameObject.Instantiate(Resources.Load ("Prefabs/JupiterExplosion") as GameObject);

			explosion.transform.position = collision.collider.gameObject.transform.position; 

			Destroy (collision.collider.gameObject); 

			Destroy (this.gameObject);

		}

		if (collision.collider.gameObject.tag == "NeptuneAlien") {

			GameObject explosion = GameObject.Instantiate(Resources.Load ("Prefabs/NeptuneExplosion") as GameObject);

			explosion.transform.position = collision.collider.gameObject.transform.position; 

			Destroy (collision.collider.gameObject); 

			Destroy (this.gameObject);

		}


		if (collision.collider.gameObject.tag == "Ally") {
			
			Destroy (this.gameObject);

		}

		if (collision.collider.gameObject.tag == "Terreno") {

			Destroy (this.gameObject);

		}
			
	}
		
		
}
