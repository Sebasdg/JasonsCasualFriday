using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public CharacterController charController;
	//public float gravity = 1;

	[Header("movement")]
	public float movementSpeed = 1;
	public float turnSpeed = 1;

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	void Update() {
		if (IngameUI.LockControlls) {
			return;
		}

		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		transform.Rotate(0, Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime, 0);
		controller.Move(moveDirection * Time.deltaTime);
	}
}
