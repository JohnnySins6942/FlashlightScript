using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    public GameObject Flashlight;
    public bool FlashlighIsOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
            FlashlighIsOpen = !FlashlighIsOpen;

        if (FlashlighIsOpen)
            Flashlight.SetActive(true);
        if(!FlashlighIsOpen)
            Flashlight.SetActive(false);
    }
}
