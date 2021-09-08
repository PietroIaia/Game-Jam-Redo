using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] lightsOff;
    [SerializeField] private GameObject[] lightsOn;
    private bool canPress = false;

    // Update is called once per frame
    void Update()
    {
        if ( canPress && Input.GetButtonDown("Fire1") ){

            foreach (GameObject element in lightsOff) {
                element.SetActive(!element.activeSelf);
            }
            foreach (GameObject element in lightsOn) {
                element.SetActive(!element.activeSelf);
            }

            GameObject.Find("Scene Manager").GetComponent<CheckLightsOn>().CheckAllLights();
        }
    }

    void OnTriggerEnter2D(Collider2D other) { if (other.gameObject.tag == "Player") canPress = true; }
    void OnTriggerExit2D(Collider2D other) { if (other.gameObject.tag == "Player") canPress = false; }
}
