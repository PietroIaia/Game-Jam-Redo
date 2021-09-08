using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLightsOn : MonoBehaviour
{
    [SerializeField] private GameObject[] lightsOn;
    [SerializeField] private GameObject hud;

    public void CheckAllLights() 
    {
        bool allOn = true;
        foreach (GameObject element in lightsOn) {
            if( !element.activeSelf ) {
                allOn = false;
            }
        }

        if ( allOn ) {
            hud.SetActive(true);
        }
    }
}
