using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDebris : MonoBehaviour
{
    [SerializeField] bool isGoingUp;
    [SerializeField] bool isGoingDown;
    [SerializeField] bool isGoingLeft;
    [SerializeField] bool isGoingRight;
    [SerializeField] float debrisSpeed;

    void Update() 
    {
        if(isGoingUp)
        {
            transform.Translate(new Vector2(0, 1)* debrisSpeed * Time.deltaTime);
        }
        if(isGoingDown)
        {
            transform.Translate(new Vector2(0, -1)* debrisSpeed * Time.deltaTime);
        }
        if(isGoingLeft)
        {
            transform.Translate(new Vector2(-1, 0)* debrisSpeed * Time.deltaTime);
        }
        if(isGoingRight)
        {
            transform.Translate(new Vector2(1, 0)* debrisSpeed * Time.deltaTime);
        }
    }
}
