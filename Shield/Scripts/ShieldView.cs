using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ShieldView : MonoBehaviour
{
    // declare vars
    public Button ShieldOnButton, ShieldOffButton;
    public ShieldModel shield;
    public Text ShieldStatusText, ShieldHealthText, ShieldStrengthText;
    private ShieldController shieldCont;
    public Slider strengthSlider;

    private void Awake()
    {
        shieldCont = GetComponent<ShieldController>();
    }
    // run on start
    private void Start()
    {
        ShieldOnButton.onClick.AddListener(shieldCont.TurnOnShield);
        ShieldOffButton.onClick.AddListener(shieldCont.TurnOffShield);
        strengthSlider.onValueChanged.AddListener(delegate { shieldCont.ChangeStrength(strengthSlider); });
        // if slider value changes, pass value
    }

    public void UpdateShield(float ShieldHealth)
    {
        // display shield health to ui
        string ShieldMessage = "Shield Health : " + ShieldHealth;

        ShieldStatusText.text = ShieldMessage;
    }

    public void UpdateShieldStatus(bool ShieldState)
    {
        // change ui value of shield on or off, depending on if shield is active
        string ShieldStatus;

        if(ShieldState) // check if shield is active
        {
            ShieldStatus = "ON";
        }
        else
        {
            ShieldStatus = "OFF";
            ShieldStatusText.text = ("Shield : OFF ");
            
        }

        ShieldStatus = "Shield : " + ShieldStatus;
        ShieldStatusText.text = ShieldStatus;
    }
    
    public void UpdateShieldHealth(float ShieldHealth, float ShieldStrength)
    {
        ShieldHealthText.text = ("Shield Health : " + ShieldHealth * ShieldStrength);
        /* multiply shield health by strength to get total health. 
         * Will change a lot until i'm happy with formula
         * can't be too strong, too weak etc..
         * leave open for upgrade team also
        */
    }

    public void UpdateShieldStrength(float ShieldStrength)
    {
        ShieldStrengthText.text = ("Shield Strength : " + ShieldStrength.ToString());
        // display shield strength
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
