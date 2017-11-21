using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootThermalRocket : MonoBehaviour {

    public float projectileSpeed = 30;
    public Rigidbody thermalRocket;


    // Use this for initialization
    void Start () {
	}

    
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.B))
        {
            Rigidbody createThermalRocket = Instantiate(thermalRocket, transform.position, transform.rotation) as Rigidbody;
            createThermalRocket.velocity = transform.TransformDirection(new Vector3(0, 0, projectileSpeed));
        }else
        {

        }
		
	}
}
