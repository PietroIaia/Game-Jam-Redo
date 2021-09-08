using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHud : MonoBehaviour
{   
    [SerializeField] private GameObject hud;
    
    public void HideHudFunction() { hud.SetActive(false); }
}
