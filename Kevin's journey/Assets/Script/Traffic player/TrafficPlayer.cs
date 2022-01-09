using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ����� �������� ������ ���������� �� ������
 */

public class TrafficPlayer : MonoBehaviour
{
    bool leftButton, rightButton;

    public float speed;
    public RotationPlayer num;

    void Start()
    {
        num = GameObject.Find("Player").GetComponent<RotationPlayer>();
    }

    void FixedUpdate()
    {
        Turn();
    }

    public void Turn()
    {

        if (leftButton == true && rightButton == false)
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        else if (leftButton == false && rightButton == true)
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
    }
    public bool LeftButton
    {
        get { return leftButton; }
        set { leftButton = value; }
    }
    public bool RightButton
    {
        get { return rightButton; }
        set { rightButton = value; }
    }
}
