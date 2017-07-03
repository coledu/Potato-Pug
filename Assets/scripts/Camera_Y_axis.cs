using UnityEngine;
using System.Collections;

public class Camera_Y_axis : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, target.position.y, -10);
	}
}
