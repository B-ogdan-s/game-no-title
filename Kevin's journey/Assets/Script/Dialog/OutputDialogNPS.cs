using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * создаёт текстовое поле и кнопки и сменяет их во время диалога
 */

public class OutputDialogNPS : MonoBehaviour
{
    public TextDialogNPS textDealog;
    public AnotherAction action;
    public GameObject textPole, button;
    Queue<GameObject> text = new Queue<GameObject>();
    GameObject[] numButton = new GameObject[0];
    float startPos = 640f;

    public void ManagerInputNPS(int numDialog)
    {
        if (numDialog == 0)
        {
            CreateText(textDealog.dialog[numDialog].phrasesForDialogue);
            CreateButton(numDialog);
        }
        else if (numDialog > 0)
        {
            DestroyButton();
            CreateText(textDealog.dialog[numDialog].phrasesForDialogue);
            CreateButton(numDialog);
        }
        else
        {
            action.Action(Mathf.Abs(numDialog));
        }
    }

    public void CreateText(string dText)
    {
        GameObject obj = Instantiate(textPole) as GameObject;
        obj.transform.SetParent(GameObject.Find("Field Text").transform);
        obj.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        obj.transform.localScale = new Vector2(1f, 1f);

        int n = dText.Length / 24;
        obj.GetComponent<RectTransform>().sizeDelta += new Vector2(0f, n * (80f+25f));

        obj.transform.localPosition = new Vector2(0f, startPos - (obj.GetComponent<RectTransform>().sizeDelta.y / 2f + 25f));

        startPos = obj.transform.localPosition.y - obj.GetComponent<RectTransform>().sizeDelta.y / 2f;

        obj.GetComponent<Text>().text = dText;
        text.Enqueue(obj);
    }

    public void DestroyText()
    {
        foreach(GameObject i in text)
        {
            Destroy(i);
        }
        text = new Queue<GameObject>();
    }

    void CreateButton(int num)
    {
        float startPosButton = 465f;
        numButton = new GameObject[textDealog.dialog[num].answerOptions.Length];
        for (int i = 0; i < textDealog.dialog[num].answerOptions.Length; i++)
        {
            GameObject obj = Instantiate(button) as GameObject;

            DialogButton dialog = obj.GetComponent<DialogButton>();
            dialog.Num = textDealog.dialog[num].answerOptions[i].numberNextDealog;
            dialog.NumD = num;
            dialog.NumA = i;
            obj.transform.SetParent(GameObject.Find("Fon Dialog").transform);
            obj.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            obj.transform.localScale = new Vector2(1f, 1f);

            int n = textDealog.dialog[num].answerOptions[i].ansver.Length / 24;
            obj.GetComponent<RectTransform>().sizeDelta += new Vector2(0f, n * 80f);

            if(i!=0)
            {
                obj.transform.localPosition = new Vector2(722f, startPosButton - (obj.GetComponent<RectTransform>().sizeDelta.y / 2f + 25f));
                startPosButton = obj.transform.localPosition.y - obj.GetComponent<RectTransform>().sizeDelta.y / 2f;
            }
            else
            {
                obj.transform.localPosition = new Vector2(722f, startPosButton);
                startPosButton -= obj.GetComponent<RectTransform>().sizeDelta.y / 2f;
            }

            Text text = obj.GetComponentInChildren<Text>(true);
            if (text != null)
            {
                text.text = textDealog.dialog[num].answerOptions[i].ansver;
            }
            numButton[i] = obj;
        }
    }

    public void DestroyButton()
    {
        foreach (GameObject i in numButton)
        {
            Destroy(i);
        }
        numButton = new GameObject[0];
    }

    public float StartPos
    {
        get { return startPos; }
        set { startPos = value; }
    }
}
