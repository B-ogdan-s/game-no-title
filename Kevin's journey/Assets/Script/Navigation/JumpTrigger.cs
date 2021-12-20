using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public int startNumJump;
    public Jump jumpPlayer;
    public string[] nameTag;

    void Start()
    {
        startNumJump = jumpPlayer.numJump;
        jumpPlayer = GameObject.Find("Player").GetComponent<Jump>();
    }

    void OnTriggerEnter(Collider jumpTrigger)
    {
        foreach (string tag_1 in nameTag)
        {
            if (jumpTrigger.gameObject.tag == tag_1)
            {
                jumpPlayer.numJump = startNumJump;
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
