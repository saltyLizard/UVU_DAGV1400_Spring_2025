using UnityEngine;

public class GameResetter : MonoBehaviour
{
    public SimpleFloatData[] floatDataObjects; // Assign your SimpleFloatData instances in the Inspector
    public SimpleIntData[] intDataObjects; // Assign your SimpleIntData instances in the Inspector

    void Start()
    {
        // Reset all SimpleFloatData instances
        foreach (SimpleFloatData data in floatDataObjects)
        {
            data.ResetValue();
        }

        // Reset all SimpleIntData instances
        foreach (SimpleIntData data in intDataObjects)
        {
            data.ResetValue();
        }
    }
}