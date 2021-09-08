using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonderPlatformsTeleport : MonoBehaviour
{
    private bool canPress = false;
    [SerializeField] private Vector3 destination;
    private GameObject player;

    // Start is called before the first frame update
    void Start() { player = GameObject.Find("Character"); }

    // Update is called once per frame
    void Update()
    {
        if ( canPress && Input.GetButtonDown("Up") ) {
            player.transform.position = new Vector3(destination.x, destination.y, destination.z);
        }
    }

    void OnCollisionEnter2D(Collision2D col) { if (col.gameObject.tag == "Player") canPress = true; }
    void OnCollisionExit2D(Collision2D col) { if (col.gameObject.tag == "Player") canPress = false; }
}
