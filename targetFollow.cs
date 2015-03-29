using UnityEngine;
using System.Collections;

public class targetFollow : MonoBehaviour {

	public float speed;
	public Transform Player;        // Reference to the player's transform.
	
	void Awake ()
	{
		//Setting up the reference.
		//Player = GameObject.FindGameObjectWithTag("Player").transform; 
		Player = GameObject.FindWithTag ("Player").transform;
	}
	
	void FixedUpdate ()
	{
		TrackPlayer();
	}
	
	void TrackPlayer ()
	{
		// By default the target x and y coordinates of the camera are it's current x and y coordinates.
		float targetX = Player.position.x;
		float targetY = Player.position.y;
		
		// Set the camera's position to the target position with the same z component.
		Vector3 v = new Vector3(targetX, targetY, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, v, Time.deltaTime * speed);
	}
}
