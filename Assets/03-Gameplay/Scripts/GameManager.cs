using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int scoreCount = 0;
    [SerializeField] SwitchDoor mySwitchDoor;

    [SerializeField] ColorChangeSwitch greenSwitch1;
    [SerializeField] ColorChangeSwitch greenSwitch2;
    [SerializeField] ColorChangeSwitch greenSwitch3;

    
    void Start() {
        if(!greenSwitch1 == null && !greenSwitch1 == null && !greenSwitch1 == null)
        {
            greenSwitch1 = GameObject.Find("ColorChangeSwitch1").GetComponent<ColorChangeSwitch>();
            greenSwitch2 = GameObject.Find("ColorChangeSwitch2").GetComponent<ColorChangeSwitch>();
            greenSwitch3 = GameObject.Find("ColorChangeSwitch3").GetComponent<ColorChangeSwitch>();
        }
    }

    public void CorrectColorCounter()
    {
        if(greenSwitch1.isCorrectColor && greenSwitch2.isCorrectColor && greenSwitch3.isCorrectColor)
        {
            mySwitchDoor.OpenDoor();
        }
    }

    public void increaseCount(){
        scoreCount++;
        if(scoreCount >= 4)
        {
            mySwitchDoor.OpenDoor();
        }
    }
}
