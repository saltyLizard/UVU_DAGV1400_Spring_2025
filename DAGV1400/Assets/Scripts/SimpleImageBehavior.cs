using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;
    
    // Start is called before the first frame update
    void Start()
    {
        imageObj = GetComponent<Image>();
        if (imageObj == null)
        {
            Debug.LogError("No Image component found on " + gameObject.name);
        }
        else
        {
            Debug.Log(gameObject.name + " found Image: " + imageObj);
        }
    }

    public void UpdateWithFloatData()
    {
        
        Debug.Log("UpdateWithFloatData() called on: " + gameObject.name);
    
        if (imageObj == null)
        {
            Debug.LogError(gameObject.name + " imageObj is NULL when calling UpdateWithFloatData()!");
            return;
        }

        if (dataObj == null)
        {
            Debug.LogError(gameObject.name + " dataObj is NULL!");
            return;
        }

        Debug.Log(gameObject.name + " updating fillAmount to " + dataObj.value);
        imageObj.fillAmount = dataObj.value;
        
        

    }
     
}
