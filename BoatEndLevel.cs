using UnityEngine;
using System.Collections;

public class BoatEndLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").transform.position.z >= 1010) {
			Application.LoadLevel ("LSD");
		}
	
	}
}
