using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_controller : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float speed;
	private bool isGrounded = true;
	public Vector2 jumpHeight;
	//private int count;
	//public Text countText;

	void Start(){
		rb2d = GetComponent <Rigidbody2D> ();
		//count = 0;
		//countText.text = "Ketchup packets: " + count.ToString ();
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
			GetComponent<Rigidbody2D> ().AddForce (jumpHeight, ForceMode2D.Impulse);
			//isGrounded = false;

		}

	}

	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * speed);

		}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag("Enemy"))
		{
			//Destroy (gameObject);
			Application.LoadLevel ("Gameover");

		}
	}


	//void OnTriggerEnter2D(Collider2D other){
		//if (other.gameObject.CompareTag ("Pickup")) 
			//{
			//other.gameObject.SetActive (false);
			//count = count + 1;
			//countText.text = "Ketchup packets: " + count.ToString ();
			//if (count  == 5) 
			//{
			//	Application.LoadLevel ("level 2");


			//}

			//}
			
		//}
		
	}