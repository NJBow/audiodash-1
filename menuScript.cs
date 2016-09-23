using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuScript : MonoBehaviour {

	public Button startText;
	// Use this for initialization
	void Start () {
		startText = startText.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartLevel () {
		Application.LoadLevel ("Road");
	}

	public void EasyLevel () {
		Application.LoadLevel ("Road");
	}

	public void MediumLevel () {
		Application.LoadLevel ("Space");
	}

	public void HardLevel () {
		Application.LoadLevel ("Boat");
	}

	public void InsaneLevel () {
		Application.LoadLevel ("LSD");
	}
}
