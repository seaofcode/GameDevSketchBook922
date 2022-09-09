using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemyDebris;
    [SerializeField] Transform debrisPosition;

    CircleCollider2D myCircleCollider2D;
    SpriteRenderer mySpriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(ExplodeCountDown());
    }

    IEnumerator ExplodeCountDown()
    {
        yield return new WaitForSecondsRealtime(1);
        mySpriteRenderer.color = Color.red;
        yield return new WaitForSecondsRealtime(1);
        mySpriteRenderer.color = Color.magenta;
        yield return new WaitForSecondsRealtime(1);
        transform.localScale = new Vector2(1.5f, 1.5f);
        yield return new WaitForSecondsRealtime(0.5f);
        mySpriteRenderer.color = Color.clear;
        Instantiate(enemyDebris, debrisPosition.position, transform.rotation);
    }

    
}
