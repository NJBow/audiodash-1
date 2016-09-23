	using UnityEngine;
	using System;

	public class MovementController : MonoBehaviour {

	public Transform[] Lanes;
		private float startTime;
		private float journeyLength;
		int i = 0;

		void Start () {

			startTime = Time.time;
		}

		
		void Update () {

		float fracJourney = 1.0f;
	
		if (Input.GetKeyDown ("right")) {

			Debug.Log ("Press");

				if (gameObject.transform.position == Lanes [i].transform.position) {
					
					if (i == 0) {
						transform.position = Vector3.Lerp (Lanes [i].transform.position, Lanes [15].transform.position, fracJourney);
						 i = 15;
					} else {
						
						transform.position = Vector3.Lerp (Lanes [i].transform.position, Lanes [i - 1].transform.position, fracJourney);
						i = i - 1;
					}
				}
			Debug.Log ("Move");
		}
			if (Input.GetKeyDown ("left")) {
			
				if (gameObject.transform.position == Lanes [i].transform.position) {
					if (i == 15) {
						transform.position = Vector3.Lerp (Lanes [i].transform.position, Lanes [0].transform.position, fracJourney);
						i = 0;
					} else {
						transform.position = Vector3.Lerp (Lanes [i].transform.position, Lanes [i + 1].transform.position, fracJourney);
						i = i + 1; 
					}
				}
			
		}

		
	
		}
}
	

