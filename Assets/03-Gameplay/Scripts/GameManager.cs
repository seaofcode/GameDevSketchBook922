using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int scoreCount = 0;
    [SerializeField] SwitchDoor mySwitchDoor;


    public void increaseCount(){
        scoreCount++;
        if(scoreCount >= 4)
        {
            mySwitchDoor.OpenDoor();
        }
    }
}
