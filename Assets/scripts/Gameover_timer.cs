using UnityEngine;
using System.Collections;

public class Gameover_timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("waitTenseconds");
	}

	// Update is called once per frame
	void Update () {

	}
	IEnumerator waitTenseconds(){
		yield return new WaitForSeconds(10);
		Application.LoadLevel("Start menu");
	}
}
