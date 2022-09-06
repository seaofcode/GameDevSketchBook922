using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    public SwitchDoor mySwitchDoorScript;
    public BlueButton myBlueButton;
    public RedSwitch myRedSwitch;
    
    void Start()
    {
        mySwitchDoorScript = GameObject.Find("WallDoor").GetComponent<SwitchDoor>();
        myBlueButton = GameObject.Find("Button").GetComponent<BlueButton>();
        myRedSwitch = GameObject.Find("Switch").GetComponent<RedSwitch>();
    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement(){
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(horInput, verInput) * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            // Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Switch")
        {
            other.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            mySwitchDoorScript.OpenDoor();
            other.gameObject.GetComponent<Collider2D>().isTrigger = false;
        }
        if(other.gameObject.tag == "Button")
        {
            other.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            myBlueButton.SpawnButton();
            other.gameObject.GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
