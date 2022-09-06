using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSwitch : MonoBehaviour
{
    public SwitchDoor mySwitchDoor;


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            mySwitchDoor.OpenDoor();
            gameObject.GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
