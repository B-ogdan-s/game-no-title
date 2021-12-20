using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody player;
    public int numJump;
    public float force;
    public bool jumpButton, jumpTrigger;

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
}
