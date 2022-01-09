using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Задаёт прыжёк играку
 */

public class Jump : MonoBehaviour
{
    public Rigidbody player;
    int numJump = 1;
    public float force;

    bool jumpButton;

    public bool jumpTrigger;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (jumpButton == true && (jumpTrigger == true || numJump > 0))
        {
            player.AddForce(Vector3.up * force, ForceMode.Impulse);
            numJump--;
            jumpButton = false;
        }
    }

    public bool JumpButton
    {
        get { return jumpButton; }
        set { jumpButton = value; }
    }

    public int NumJump
    {
        get { return numJump; }
        set { numJump = value; }
    }
}