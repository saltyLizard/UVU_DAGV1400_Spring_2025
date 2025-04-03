using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
    public float currentValue;
    public float startValue;

    public void ResetValue()
    {
        currentValue = startValue;
    }

    public void UpdateValue(float amount)
    {
        currentValue += amount;
    }

    public void SetValue(float amount)
    {
        currentValue = amount;
    }
}