using UnityEngine.UI;
using UnityEngine;

public class BlastCharge : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxEnergy(float energy)
    {
        slider.maxValue = energy;
        slider.value = energy;
    }
    public void SetEnergyValue(float energy)

    {
        slider.value = energy;
    }

}
