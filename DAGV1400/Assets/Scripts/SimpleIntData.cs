using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/SimpleIntData")]
public class SimpleIntData : ScriptableObject
{
    public int value;
    
    public void UpdateValue(int amount)
    {
        value += amount;
        Debug.Log("Int Data changed by " + value);
    }

    public void SetValue(int amount)
    {
        value = amount;
    }
}
