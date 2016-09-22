using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PauseGame : MonoBehaviour {

	public Transform canvas;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
			
		Pause ();

	}


	public void Pause() 
	{
		AudioSource audio = GetComponent<AudioSource>();

			if (canvas.gameObject.activeInHierarchy == false) {
				canvas.gameObject.SetActive (true);
				Time.timeScale = 0;
				audio.Pause();

			} else 

			{
				canvas.gameObject.SetActive (false);
				Time.timeScale = 1;
				audio.Play();

			}
		}
	}
