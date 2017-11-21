using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class ShieldController : MonoBehaviour
{

    public ShieldModel shield;
    private ShieldView sView;

    void Start()
    {
        //Create new ShieldModel object
        shield = new ShieldModel();
        sView = GetComponent<ShieldView>();
        sView.UpdateShieldStatus(shield.GetIsOn());
        sView.UpdateShieldHealth(shield.GetShieldHealth(), shield.GetShieldStrength());
        sView.UpdateShieldStrength(shield.GetShieldStrength());
        StartCoroutine(RegenShield());
        
    }

    private void Update()
    {
        sView.UpdateShieldHealth(shield.GetShieldHealth(), shield.GetShieldStrength());
        
    }

    public void ChangeStrength(Slider StrengthSlider) // changing shield strength with slider
    {
        if(shield.isOn)
        {
            shield.SetShieldStrength((StrengthSlider.value));
            sView.UpdateShieldStrength(shield.GetShieldStrength());
            StrengthSlider.interactable = true;
        }
        else
        {
            StrengthSlider.interactable = false; // can't move slider if shield inactive
            Debug.Log("Shield is not on, can't change power.");
        }
    }

    public void TurnOnShield() // turn shield on 
    {
        if(!shield.GetIsOn())
        {
            Debug.Log("Shield turned on");
            shield.SetIsOn(true);
            sView.UpdateShieldStatus(shield.GetIsOn());
           
        }
        else
        {
            Debug.Log("Shield already on!");
        }
    }
    public void TurnOffShield() // turn shield off
    {
        if (shield.GetIsOn())
        {
            Debug.Log("Shield turned off");
            shield.SetIsOn(false); // set shield bool to false
            sView.UpdateShieldStatus(shield.GetIsOn()); // update
            shield.SetShieldStrength(0); // remove shield strength, set to 0 
            
        }
        else
        {
            Debug.Log("Shield if already off");
        }

    }

    IEnumerator RegenShield()
    {
        while(true) // do forever while shield health less than 100
        {
            if(shield.ShieldHealth < 500) // if shield health is less than 100
            {
                shield.ShieldHealth += 1; // increase shield health
                yield return new WaitForSeconds(1); // wait one second, regen again
            } else // if it is more than 500 just return null 
            {
                yield return null;
            }
        }
    }
    void OnCollisionEnter(Collision col) // on collision, depending on tag type, apply damage to health
    {
        if(col.gameObject.tag == "Cannon")
        {
            shield.ShieldHealth = shield.ShieldHealth - 100; 
            Debug.Log("Hit by a cannon. -100 health.");
            shield.SetWasDamaged(true);
        }
        if(col.gameObject.tag == "Missile")
        {
            shield.ShieldHealth = shield.ShieldHealth - 150;
            Debug.Log("Hit by a missile. -150 health");
            shield.SetWasDamaged(true);
        }
        if (col.gameObject.tag == "enemyShip")
        {
            Debug.Log("Enemy ship collided. -500 health");
        }


    }
}
