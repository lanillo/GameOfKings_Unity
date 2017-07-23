using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour {

	// Create objects for player
	Rigidbody2D rBody;
	Animator anim;

	// Use this for initialization
	void Start () {

		// Access both objects
		rBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();


		
	}
	
	// Update is called once per frame
	void Update () {

		// Raw so it is an integer and not a float
		// If you want a float, it's GetAxis
		Vector2 mouvementVector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		if (mouvementVector != Vector2.zero) {
			anim.SetBool ("isWalking", true);
			anim.SetFloat ("inputX", mouvementVector.x);
			anim.SetFloat ("inputY", mouvementVector.y);				
		} else {
			anim.SetBool ("isWalking", false);
		}

		// We now move from our current position to the new position
		rBody.MovePosition (rBody.position + mouvementVector * Time.deltaTime);

	}
}
