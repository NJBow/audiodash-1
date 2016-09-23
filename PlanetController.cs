using UnityEngine;
using System.Collections;

public class PlanetController : MonoBehaviour {

	public float Speed;

	// Update is called once per frame
	void Update () {

		transform.Rotate (0, 0, Speed * Time.deltaTime);

	}

}