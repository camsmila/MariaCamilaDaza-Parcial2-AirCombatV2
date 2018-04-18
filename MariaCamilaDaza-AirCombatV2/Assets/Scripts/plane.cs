using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (-0.5f, 0.0f, 0.0f);


		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 2.0f, 0.0f);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -2.0f, 0.0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (0.0f, 0.0f, -2.0f);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (0.0f, 0.0f, 2.0f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {

			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Missile") as GameObject);

			missile.transform.SetParent (this.gameObject.transform);

			missile.transform.localPosition = new Vector3 (2.035438f, -2.56f, 5.46f);

			missile.transform.SetParent (null);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {

			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Missile2") as GameObject);

			missile.transform.SetParent (this.gameObject.transform);

			missile.transform.localPosition = new Vector3 (0.67f, -2.82f, -4.8f);

			missile.transform.SetParent (null);
		}

	}
}
