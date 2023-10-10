using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] GameObject hindgeBarBell;

    private void OnTriggerEnter2D(Collider2D other) {
        hindgeBarBell.SetActive(true);
    }
}
