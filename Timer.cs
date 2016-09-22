using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float time = 0.0f;
	TextMesh tm;

	// Use this for initialization
	void Start () {

		tm = GetComponent<TextMesh>();
	
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;
		tm.text = Mathf.RoundToInt(time).ToString();
	}
}

