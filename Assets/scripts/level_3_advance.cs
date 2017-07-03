using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class level_3_advance : MonoBehaviour {

	private int count;
	public Text countText;

	// Use this for initialization
	void Start () {
		count = 0;
		countText.text = "Ketchup packets: " + count.ToString ();
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Pickup")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			countText.text = "Ketchup packets: " + count.ToString ();
		}
		else 
		{
			if (other.gameObject.CompareTag ("Button") && count == 5) {
				//Destroy (other.gameObject);
				other.gameObject.SetActive (false);
				StartCoroutine ("waitThreeseconds");
				//yield return new WaitForSeconds (3);
				//Application.LoadLevel ("Final");

			}

			}
	
	}

	IEnumerator waitThreeseconds(){
		yield return new WaitForSeconds (3);
		Application.LoadLevel ("Final");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
