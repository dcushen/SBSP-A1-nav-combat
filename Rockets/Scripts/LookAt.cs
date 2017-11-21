using UnityEngine;

public class LookAt : MonoBehaviour {
	public Transform target;
	public float speed = 5f;
	// Update is called once per frame
	void Update () {
		Vector3 direction = target.position - transform.position;
		float step = speed * Time.deltaTime;
		Vector3 newDirection = Vector3.RotateTowards (transform.forward, direction, step, 0.0f);
		//Debug.DrawRay (transform.position, newDirection, Color.red);
		//transform.rotation = Quaternion.LookRotation (newDirection);
	}
}
