using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    private bool canPress = false;
    [SerializeField] private string sceneName;
    
    // Update is called once per frame
    void Update()
    {
        if ( !LockedDoors.isDoorLocked(sceneName) && canPress && Input.GetButtonDown("Up") ){
            SceneManager.LoadScene(sceneName);
        }
    }

    void OnTriggerEnter2D(Collider2D other) { if (other.gameObject.tag == "Player") canPress = true; }
    void OnTriggerExit2D(Collider2D other) { if (other.gameObject.tag == "Player") canPress = false; }
}
