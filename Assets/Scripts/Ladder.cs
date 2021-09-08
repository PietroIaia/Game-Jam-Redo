using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    [SerializeField]
    private float speed = 6;
    [SerializeField]
    private GameObject ladderCenter;
    private bool onLadder = false;

    void MoveCharacterToCenterLadder(GameObject go)
    {
        go.transform.position = new Vector3(
            ladderCenter.transform.position.x, 
            go.transform.position.y,
            go.transform.position.z
        );
    }

    void OnTriggerStay2D(Collider2D other) 
    {   
        if ( other.tag == "Player" && Input.GetButton("Up") ) {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            onLadder = true;
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1000;
            MoveCharacterToCenterLadder(other.gameObject);
        }
        else if ( other.tag == "Player" && Input.GetButton("Down") ) {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            onLadder = true;
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1000;
            MoveCharacterToCenterLadder(other.gameObject);
        }
        else if ( onLadder ) {
            // We do this so that the character doesn't fall down the ladder
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(other.GetComponent<Rigidbody2D>().velocity.x, 0);
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        onLadder = false;
        other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
    }
}
