using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSwitch : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            gameManager.increaseCount();
            gameObject.GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
