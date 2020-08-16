using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Manager : MonoBehaviour
{
    public Text text;

    public void changeLevel(int levelValue)
    {
        text.text = levelValue.ToString();
    }


}
