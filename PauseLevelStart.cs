using UnityEngine;
using System.Collections;

public class PauseLevelStart : MonoBehaviour {
		
	public void RoadLevel () {
		Application.LoadLevel ("Road");
		Time.timeScale = 1;
	}

	public void LsdLevel () {
		Application.LoadLevel ("LSD");
		Time.timeScale = 1;
	}

	public void BoatLevel()
	{
		Application.LoadLevel ("Boat");
		Time.timeScale = 1;

	}

	public void SpaceLevel()
	{
		Application.LoadLevel ("Space");
		Time.timeScale = 1;

	}
}
