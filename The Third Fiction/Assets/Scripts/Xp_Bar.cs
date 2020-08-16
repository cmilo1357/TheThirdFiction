using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xp_Bar : MonoBehaviour
{

    public Slider slider;

    public void SetXp(int xp)
    {
        slider.value = xp;
    }


}
