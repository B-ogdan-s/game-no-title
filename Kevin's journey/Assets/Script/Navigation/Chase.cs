using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        if(player.transform.localPosition.y >= 0f)
        {
            transform.localPosition = player.transform.localPosition;
            transform.rotation = Quaternion.Euler(0f, player.transform.rotation.eulerAngles.y, 0f);
        }
    }
}
