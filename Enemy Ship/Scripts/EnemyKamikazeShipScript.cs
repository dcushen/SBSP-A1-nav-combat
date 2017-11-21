using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKamikazeShipScript : MonoBehaviour {

    private GameObject ship;
    public float speed = 40.0f;

	// Use this for initialization
	void Start () {
        ship = GameObject.FindGameObjectWithTag("ship");

	}

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ship")
        {
            Destroy(collision.gameObject);
            Debug.Log("Exploded enemy ship!!!");
        }
    }
    // Update is called once per frame
    void Update () {
        var distance = Vector3.Distance(ship.transform.position, transform.position);
        if (distance < 200)
        {
            var d = ship.transform.position - transform.position;
            d.Normalize();
            var moveShip = speed * Time.deltaTime;
            transform.position = transform.position + (d * moveShip);
            transform.LookAt(ship.transform);
        }
        else
        {

        }
	}
}
