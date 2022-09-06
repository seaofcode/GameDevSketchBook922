using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour
{
    [SerializeField] GameObject redSwitch;
    

    public void SpawnButton(){
        redSwitch.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            gameObject.GetComponent<Collider2D>().isTrigger = false;
            SpawnButton();
        }
    }
}
