using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationOfMovementButtons : MonoBehaviour
{
    public float coordinatX, coordinatY;

    void Start()
    {
        transform.localPosition = new Vector2(coordinatX * Screen.width / 2960f, coordinatY * Screen.height / 1440f);
        transform.localScale = new Vector2(Screen.width / 2960f, Screen.width / 2960f);
    }
}
