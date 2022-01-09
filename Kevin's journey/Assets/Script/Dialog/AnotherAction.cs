using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Этот скрипт вызывает методы другтг класов при выборе дальнейшого варианта диалога еслти тот должен выплонять какоето действие
 * (выход из диалога открытие магазина, взятие квеста)
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
                Debug.Log("Такого значения нету!!!!");
                break;
        }
    }
}
