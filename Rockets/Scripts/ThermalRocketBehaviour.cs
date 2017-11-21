using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermalRocketBehaviour : MonoBehaviour {

    private GameObject EnemyKamikazeShip;
	// Use this for initialization
	void Start () {
        EnemyKamikazeShip = GameObject.FindGameObjectWithTag("Enemy Kamikaze Ship");

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy Kamikaze Ship")
        {
            Destroy(collision.gameObject);
            Debug.Log("Destroyed Kamikaze!!");
        }
    }

    // Update is called once per frame
    void Update () {
        var distance = Vector3.Distance(EnemyKamikazeShip.transform.position, transform.position);

        
        if (distance < 500)
        {
            var speed = 60;
            var d = EnemyKamikazeShip.transform.position - transform.position;
            d.Normalize();
            var moveRocket = speed * Time.deltaTime;
            transform.position = transform.position + (d * moveRocket);
            transform.LookAt(EnemyKamikazeShip.transform);
        }
    }
}
