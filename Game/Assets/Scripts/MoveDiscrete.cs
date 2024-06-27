using UnityEngine;
using System.Collections;


// this movement function moves in one hit the amount of distance specified
public class MoveDiscrete : MonoBehaviour 
{
	public KeyCode leftKey;
	public KeyCode rightKey;
	public KeyCode upKey;
	public KeyCode downKey;

	public float distanceX;
	public float distanceY;


	private Rigidbody2D rigidBody;


	// Use this for initialization
	void Start () 
	{
		rigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (leftKey))	rigidBody.MovePosition(transform.position + new Vector3 (-distanceX, 0, 0));
		if (Input.GetKeyDown (rightKey))rigidBody.MovePosition(transform.position + new Vector3 (distanceX, 0, 0));
		if (Input.GetKeyDown (upKey))	rigidBody.MovePosition(transform.position + new Vector3 (0, distanceY, 0));
		if (Input.GetKeyDown (downKey))	rigidBody.MovePosition(transform.position + new Vector3 (0, -distanceY, 0));
	}
}
