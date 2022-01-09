using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ���� ���� ������ � ���� ��� ������  NPS ��� �������� � ����� ������ �� ��� � �������� �� �����������.
 */

public class TextDialogNPS : MonoBehaviour
{
    public Dialog[] dialog;
}

[System.Serializable]
public class Dialog
{
    [TextArea(2, 15)]
    public string phrasesForDialogue;
    public Ansver[] answerOptions;
}

[System.Serializable]
public class Ansver
{
    [TextArea(2, 15)]
    public string ansver;
    public int numberNextDealog;
}