using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeSwitch : MonoBehaviour
{
    [SerializeField] bool isBlue;
    [SerializeField] bool isGreen;
    [SerializeField] bool isRed;

    private SpriteRenderer spriteRenderer;

    public GameManager gameManager;
    public bool isCorrectColor;
    

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if(isBlue){
            spriteRenderer.color = Color.blue;
        }
        if(isGreen){
            spriteRenderer.color = Color.green;
            isCorrectColor = true;
        }
        if(isRed){
            spriteRenderer.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player")
        {
            TurnColor();
        }
    }

    void TurnColor()
    {
        if(isBlue){
            spriteRenderer.color = Color.red;
            isBlue = false;
            isRed = true;
            isCorrectColor = false;
        }
        else if(isRed){
            spriteRenderer.color = Color.green;
            isRed = false;
            isGreen = true;
            isCorrectColor = true;
            gameManager.CorrectColorCounter();
        }
        else if(isGreen){
            spriteRenderer.color = Color.blue;
            isGreen = false;
            isBlue = true;
            isCorrectColor = false;
        }
    }
}
