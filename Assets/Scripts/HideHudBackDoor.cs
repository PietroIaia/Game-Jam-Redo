using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHudBackDoor : MonoBehaviour
{
    [SerializeField] private GameObject hud;
    [SerializeField] private GameObject[] texts;
    private int index = 0;

    public void HideHudFunction() 
    {
        if (index <= 4) {
            texts[index].SetActive(false);
            texts[index+1].SetActive(true);
            index += 1;
        }
        else {
            texts[5].SetActive(false);
            texts[4].SetActive(true);
        }
        hud.SetActive(false); 
    }
}
