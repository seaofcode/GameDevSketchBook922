using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSwitch : MonoBehaviour
{
    [SerializeField] GameObject activeSwitch;
    [SerializeField] GameObject activeLight;
    [SerializeField] GameObject activeEnemy;
    

    public void SpawnSwitch()
    {
        activeSwitch.SetActive(true);
    
    }
    public void SpawnLight()
    {
        activeLight.SetActive(true);
    }
    public void SpawnEnemy()
    {
        activeEnemy.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            gameObject.GetComponent<Collider2D>().isTrigger = false;
            SpawnSwitch();
            SpawnLight();
            SpawnEnemy();
        }    
    }
}
