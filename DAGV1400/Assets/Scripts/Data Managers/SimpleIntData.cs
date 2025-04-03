using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/SimpleIntData")]
public class SimpleIntData : ScriptableObject
{
    public int currentValue;
    public int startValue;
    
    public void ResetValue()
    {
        currentValue = startValue;
    }
    
    public void UpdateValue(int amount)
    {
        currentValue += amount;
        Debug.Log("Int Data changed by " + currentValue);
    }

    public void SetValue(int amount)
    {
        currentValue = amount;
    }
    
    
}
