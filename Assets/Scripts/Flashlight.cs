using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private bool controll;
    public Light light, lightReturn;

    void Start()
    {
        light = GameObject.Find("Flashlight").GetComponent<Light>();
        lightReturn = GameObject.Find("FlashlightReturn").GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            ControllLight();
    }

    void ControllLight()
    {
        if (controll)
            controll = false;
        else
            controll = true;
           
        light.enabled = controll;
        lightReturn.enabled = controll;
    }
}
