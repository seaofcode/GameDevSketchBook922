using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    
    public void OpenDoor(){
        transform.Translate(new Vector2(-4,0));
    }
}
