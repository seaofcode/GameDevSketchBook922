using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionShow : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireworkShow());
    }

    IEnumerator FireworkShow()
    {
        yield return new WaitForSecondsRealtime(1);
    }
}
