using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xp_Bar : MonoBehaviour
{

    public Slider slider;

    public void setXp(int xp)
    {
        slider.value = xp;
    }


}
