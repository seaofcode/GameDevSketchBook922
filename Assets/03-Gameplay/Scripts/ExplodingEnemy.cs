using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemyDebris;
    [SerializeField] Transform debrisPosition;

    Animator myAnimator;
    CircleCollider2D myCircleCollider2D;
    SpriteRenderer mySpriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myAnimator = GetComponent<Animator>();
        StartCoroutine(ExplodeCountDown());
    }



    IEnumerator ExplodeCountDown()
    {
        myAnimator.SetBool("isCountingDown", true);
        yield return new WaitForSecondsRealtime(2.8f);
        Instantiate(enemyDebris, debrisPosition.position, transform.rotation);
        mySpriteRenderer.color = Color.clear;
        myAnimator.SetBool("isCountingDown", false);
        gameObject.SetActive(false);
    }

    
}
