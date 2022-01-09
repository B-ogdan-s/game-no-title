using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * открывает меню диалога (тут есть метод что бы его и закрть)
 */

public class DialogClick : MonoBehaviour
{
    public GameObject buttonLife, buttonRight, compass, buttonUp, buttonAttack, backpack, dealog, dealogFon;
    public CamTouch touch;
    public OutputDialogNPS manager;

    private void Start()
    {
        buttonLife = GameObject.Find("Left Button Go");
        buttonRight = GameObject.Find("Right Button Go");
        compass = GameObject.Find("Compass Fon");
        buttonUp = GameObject.Find("Up Button");
        buttonAttack = GameObject.Find("Attack");
        backpack = GameObject.Find("Backpack");
        dealog = GameObject.Find("Dialog");
        dealogFon = GameObject.Find("Fon Dialog");
        manager = GameObject.Find("Fon Dialog").GetComponent<OutputDialogNPS>();
    }
    public void DialogButtonOpen()
    {
        buttonLife.transform.localPosition += new Vector3(0f, -300f, 0f);
        buttonRight.transform.localPosition += new Vector3(0f, -300f, 0f);
        buttonUp.transform.localPosition += new Vector3(0f, -300f, 0f);
        buttonAttack.transform.localPosition += new Vector3(300f, 0f, 0f);
        compass.transform.localPosition += new Vector3(0f, 700f, 0f);
        backpack.transform.localPosition += new Vector3(0f, 300f, 0f);
        dealog.transform.localPosition += new Vector3(700f, 0f, 0f);
        dealogFon.transform.localPosition -= new Vector3(0f, 1600f * Screen.height / 1440, 0f);
        touch.enabled = false;

        manager.ManagerInputNPS(0);
    }

    public void DialogButtonClose()
    {
        buttonLife.transform.localPosition -= new Vector3(0f, -300f, 0f);
        buttonRight.transform.localPosition -= new Vector3(0f, -300f, 0f);
        buttonUp.transform.localPosition -= new Vector3(0f, -300f, 0f);
        buttonAttack.transform.localPosition -= new Vector3(300f, 0f, 0f);
        compass.transform.localPosition -= new Vector3(0f, 700f, 0f);
        backpack.transform.localPosition -= new Vector3(0f, 300f, 0f);
        dealog.transform.localPosition -= new Vector3(700f, 0f, 0f);
        dealogFon.transform.localPosition += new Vector3(0f, 1600f * Screen.height / 1440, 0f);
        manager.DestroyText();
        manager.DestroyButton();
        manager.StartPos = 640f;
        touch.enabled = true;
    }
}
