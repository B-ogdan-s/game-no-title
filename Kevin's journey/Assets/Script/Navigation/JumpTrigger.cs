using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Проверяет чи находится игрок на земле или же он прыгнул
 */

public class JumpTrigger : MonoBehaviour
{
    public int startNumJump;
    public CamTouch touch;
    public Jump jumpPlayer;
    public string[] nameTag;

    void Start()
    {
        touch = GameObject.Find("Player Coordinates").GetComponent<CamTouch>();
        startNumJump = jumpPlayer.NumJump;
        jumpPlayer = GameObject.Find("Player").GetComponent<Jump>();
    }

    void OnTriggerEnter(Collider jumpTrigger)
    {
        foreach (string tag_1 in nameTag)
        {
            if (jumpTrigger.gameObject.tag == tag_1)
            {
                jumpPlayer.NumJump = startNumJump;
                touch.enabled = true;
            }
        }
    }

    void OnTriggerStay(Collider jumpTrigger)
    {
        foreach (string tag_1 in nameTag)
        {
            if (jumpTrigger.gameObject.tag == tag_1)
            {
                jumpPlayer.jumpTrigger = true;
            }
        }
    }
    void OnTriggerExit(Collider jumpTrigger)
    {
        foreach (string tag_1 in nameTag)
        {
            if (jumpTrigger.gameObject.tag == tag_1)
                jumpPlayer.jumpTrigger = false;
        }
    }
}
