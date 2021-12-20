using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButtonClick : MonoBehaviour
{
    public TrafficPlayer player;
    public Jump jumpPlayer;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<TrafficPlayer>();
        jumpPlayer = GameObject.Find("Player").GetComponent<Jump>();
    }

    public void LeftButtonClickDown()
    {
        player.leftButton = true;
    }
    public void LeftButtonClickUp()
    {
        player.leftButton = false;
    }

    public void RightButtonClickDown()
    {
        player.rightButton = true;
    }
    public void RightButtonClickUp()
    {
        player.rightButton = false;
    }

    public void JumpButtonClicDown()
    {
        jumpPlayer.jumpButton = true;
    }
    public void JumpButtonClicUp()
    {
        jumpPlayer.jumpButton = false;
    }
}
