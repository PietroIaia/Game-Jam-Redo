using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDoorManager : MonoBehaviour
{
    private bool canPress = false;
    [SerializeField] private GameObject hud;

    // Update is called once per frame
    void Update()
    {
        if ( canPress && Input.GetButtonDown("Up") ){
            hud.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other) { if (other.gameObject.tag == "Player") canPress = true; }
    void OnTriggerExit2D(Collider2D other) { if (other.gameObject.tag == "Player") canPress = false; }
}
