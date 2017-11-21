using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour {

	public const int ShipArmor = 100;
	public int CurrentArmor; 
	public bool IsDamageable;

	void Start() { 
		CurrentArmor = ShipArmor;
		print ("Current armor is : " + ShipArmor);
	}

	void OnCollisionEnter(Collision _collision) { 
		if (IsDamageable = true &&_collision.gameObject.tag == "missile") { 
			CurrentArmor -= 15;
			print ("Damaged from a missile!" + CurrentArmor);
		}
	}
}
