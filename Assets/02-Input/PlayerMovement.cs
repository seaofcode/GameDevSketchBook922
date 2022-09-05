using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hoizInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(hoizInput, vertInput) * moveSpeed * Time.deltaTime);
    }
}
