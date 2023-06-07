using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
    Destroy(collider.gameObject); //При столкновении с тригером уничтажаются объекты
    Debug.Log("Yay");
    }
}