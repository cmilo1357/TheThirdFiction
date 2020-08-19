using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum EItemType
    {
        HealthPotion,
        ManaPotion,
        Coin
    }

    public EItemType itemType;
    public int amount;

}
