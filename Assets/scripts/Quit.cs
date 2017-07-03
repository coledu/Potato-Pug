using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("waitTweatyseconds");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator waitTweatyseconds(){
		yield return new WaitForSeconds(20);
		Application.Quit ();
	}
}
