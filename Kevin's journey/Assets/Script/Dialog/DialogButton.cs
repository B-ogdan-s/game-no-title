using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Определяет какая кнопка была нажата во время диалога и вызывает следующий 
 */

public class DialogButton : MonoBehaviour
{
    OutputDialogNPS dialogNPS;
    int num, numD, numA;
    void Start()
    {
        dialogNPS = GameObject.Find("Fon Dialog").GetComponent<OutputDialogNPS>();

        Button but = GetComponent<Button>();
        but.onClick.AddListener(NextDialog);
    }

    void NextDialog()
    {
        dialogNPS.CreateText(dialogNPS.textDealog.dialog[numD].answerOptions[numA].ansver);
        dialogNPS.ManagerInputNPS(num);
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    public int NumD
    {
        get { return numD; }
        set { numD = value; }
    }

    public int NumA
    {
        get { return numA; }
        set { numA = value; }
    }
}
