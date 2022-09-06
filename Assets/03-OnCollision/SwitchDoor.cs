using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    public bool hasActive = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        if(hasActive)
        {
            transform.Translate(new Vector2(-4,0));
            hasActive = false;
        }
    }


}
