using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public Rigidbody projectile;

	public float speed = 10;

	void Start(){

		}
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.A)){
			Rigidbody instantiatedProjectile = Instantiate(projectile,
			                                               transform.position,
			                                               transform.rotation)
															as Rigidbody;

			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0,0,speed));

	
	}
}
}