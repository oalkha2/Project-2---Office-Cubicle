using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoBall_Light : MonoBehaviour
{
    Light[] lightArray;
    bool light_isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        lightArray = GetComponentsInChildren<Light>();
    }

    public void toggle_LightState()
    {
        for (int i = 0; i < lightArray.Length; i++)
        {
            lightArray[i].enabled = !lightArray[i].enabled;
        }
    }
}
