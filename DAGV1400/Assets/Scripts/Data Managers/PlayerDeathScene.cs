using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDeathScene : MonoBehaviour
{
    public SimpleFloatData dataobj;

    // Update is called once per frame
    void Update()
    {
        if (dataobj.currentValue <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
