using UnityEngine;
using System.Collections;

public class Startbutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Application.LoadLevel ("level 1");
		//Startbutton.GetComponentInChildren<Text>().text="Start";
		//Startbutton.onClick.AddListener();
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	public void onClick(){

		Application.LoadLevel ("level 1");
	}
}
