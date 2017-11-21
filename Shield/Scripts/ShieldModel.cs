public class ShieldModel
{
    // declare vars
    public float ShieldHealth = 500;
    public float ShieldStrength = 0;
    public bool isOn = false;
    public bool WasDamaged = false;

    public void SetShieldHealth(int ShieldHealth)
    {
        this.ShieldHealth = ShieldHealth;
    }

    public float GetShieldHealth()
    {
        return this.ShieldHealth;
    }

    public void SetShieldStrength(float ShieldStrength)
    {
        this.ShieldStrength = ShieldStrength;
    }

    public float GetShieldStrength()
    {
        return this.ShieldStrength;
    }

    public bool GetIsOn()
    {
        return this.isOn;
    }

    public void SetIsOn(bool isOn)
    {
        this.isOn = isOn;
    }

    public void SetWasDamaged(bool WasDamaged)
    {
        this.WasDamaged = WasDamaged;
    }

    public bool GetWasDamaged()
    {
        return this.WasDamaged;
    }
}
