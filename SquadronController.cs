using UnityEngine;
using System.Collections;

public class SquadronController : MonoBehaviour {

	public float Speed;

		// Update is called once per frame
		void Update () {

		transform.Translate (0, 0, Speed * Time.deltaTime);
		transform.Translate ( Speed * Time.deltaTime, 0, 0);

		}
	
	}
