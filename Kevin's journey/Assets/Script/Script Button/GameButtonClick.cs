using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * проверяет нажатие на основные игровые кнопки (движение, прыжёк)
 */

public class GameButtonClick : MonoBehaviour
{
    CamTouch touch;
    TrafficPlayer player;
    Jump jumpPlayer;

    void Start()
    {
        touch = GameObject.Find("Player Coordinates").GetComponent<CamTouch>();
        player = GameObject.Find("Player").GetComponent<TrafficPlayer>();
        jumpPlayer = GameObject.Find("Player").GetComponent<Jump>();
    }

    public void LeftButtonClickDown()
    {
        player.LeftButton = true;
        touch.enabled = false;
    }
    public void LeftButtonClickUp()
    {
        player.LeftButton = false;
        touch.enabled = true;
    }

    public void RightButtonClickDown()
    {
        player.RightButton = true;
        touch.enabled = false;
    }
    public void RightButtonClickUp()
    {
        player.RightButton = false;
        touch.enabled = true;
    }

    public void JumpButtonClicDown()
    {
        jumpPlayer.JumpButton = true;
        touch.enabled = false;
    }
    public void JumpButtonClicUp()
    {
        jumpPlayer.JumpButton = false;
    }
}
