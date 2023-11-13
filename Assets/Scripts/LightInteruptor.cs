using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInteruptor : MonoBehaviour, IUsableObject
{
    private bool isActive = false;
    public void UseObject()
    {
        SwitchLight();
    }
    private void SwitchLight()
    {
        isActive = !isActive;
        Light light = GetComponentInChildren<Light>();
        light.enabled = isActive;
    }
}
