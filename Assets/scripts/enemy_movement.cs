using UnityEngine;
using System.Collections;

public class enemy_movement : MonoBehaviour {

	public float moveSpeed;


	void Update () {
		Vector3 vec = new Vector3 (moveSpeed, 0, 0);
		transform.Translate(vec * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D other){
		
		if(other.gameObject.CompareTag("forcefield")){
			moveSpeed *= -1;
		}
	}
}
