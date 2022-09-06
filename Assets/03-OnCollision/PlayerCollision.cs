using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    public SwitchDoor mySwitchDoorScript;
    
    void Start()
    {
        mySwitchDoorScript = GameObject.Find("WallDoor").GetComponent<SwitchDoor>();
    }

    void Update()
    {
        playerMovement();
    }

    void playerMovement(){
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(horInput, verInput) * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Switch")
        {
            other.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            mySwitchDoorScript.hasActive = true;
        }
    }
}
