using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	/*public Rigidbody player;
	public float speed;

	private Vector3 mouse;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		

		//Vector3 camera = new Vector3 (mousex, mousey, 0.0f);
		mouse = Input.mousePosition;
		player.rotation = //Quaternion.Euler (new Vector3 (Input.GetAxis ("MouseX"), Input.GetAxis ("MouseY"), 0));
			Quaternion.Euler (mouse.y * -1, mouse.x, 0.0f);
		//player.AddForce(movement * speed);

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		player.velocity = movement * speed;
	}*/




	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}
