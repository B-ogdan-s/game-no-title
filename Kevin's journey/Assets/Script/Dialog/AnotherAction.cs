using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ���� ������ �������� ������ ������ ������ ��� ������ ����������� �������� ������� ����� ��� ������ ��������� ������� ��������
 * (����� �� ������� �������� ��������, ������ ������)
 */

public class AnotherAction : MonoBehaviour
{
    public DialogClick dialogClock;
    public void Action(int num)
    {
        switch(num)
        {
            case 1:
                dialogClock.DialogButtonClose();
                break;

            case 2:
                Debug.Log("OK");
                break;

            default:
                Debug.Log("������ �������� ����!!!!");
                break;
        }
    }
}
