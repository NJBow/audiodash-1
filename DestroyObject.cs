using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.transform.position.z < GameObject.Find ("Player").transform.position.z - 5) {
			
			Destroy (this.gameObject);

		}
	
	}
}
