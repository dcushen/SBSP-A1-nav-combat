using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipShield : MonoBehaviour {
	public bool IsShieldActive;
    public int ShieldStrength = 300, i = 0;
    public Text ShieldStrengthUI;
    public float CountInterval = 0.05f, timer = 0;

    void OnCollisionEnter(Collision _collision) { 
		if (ShieldStrength == 0) {
			print ("Shield not active, taking damage!");
		} else if (IsShieldActive == true && _collision.gameObject.tag == "missile") { 
			Destroy (gameObject);
			ShieldStrength -= 30;
			print ("Hit by a missile, shield damaged!!! Shield health : " + ShieldStrength);
		}

	}

    private void Update()
    {
        timer += Time.deltaTime;

        if (ShieldStrength > 100)
        {
            ShieldStrength += 10 * 1;
            print("Shield regenerating" + ShieldStrength);

        }
    }
}