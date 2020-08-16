using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xp_Bar : MonoBehaviour
{

    public Slider slider;
    public Image fill;

    public void setXp(int xp)
    {
        slider.value = xp;
    }

    public void resetBar()
    {
        slider.value = slider.minValue;
    }

}
