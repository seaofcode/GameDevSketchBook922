using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] LevelExit myLevelReload;


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
            Destroy(gameObject);
            myLevelReload.ReloadLevel();
        }
    }
}
