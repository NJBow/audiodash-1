using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Speed;
	Vector3 startPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (0f, 0f, Speed * Time.deltaTime);

			
	}

}
