using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Level_2_advance : MonoBehaviour {

	private int count;
	public Text countText;

	void Start()
	{
		count = 0;
		countText.text = "Ketchup packets: " + count.ToString ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Pickup")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			countText.text = "Ketchup packets: " + count.ToString ();
			if (count  == 5) 
			{
				Application.LoadLevel ("level 3");

			}

		}

	}
}
