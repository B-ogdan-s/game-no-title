using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * проверяет нажатие на кнопку открытия и закрытия панели инвентаря
 */

public class BackpassButtonClick : MonoBehaviour
{
    GameObject buttonLife, buttonRight, compass, buttonUp, buttonAttack, backpack, exit, dialog;
    public CamTouch touch;
    public BackpassScript bScript;

    private void Start()
    {
        buttonLife = GameObject.Find("Left Button Go");
        buttonRight = GameObject.Find("Right Button Go");
        compass = GameObject.Find("Compass Fon");
        buttonUp = GameObject.Find("Up Button");
        buttonAttack = GameObject.Find("Attack");
        backpack = GameObject.Find("Backpack");
        exit = GameObject.Find("Exit");
        dialog = GameObject.Find("Dialog");
    }
    public void BackassButtonOpen()
    {
        buttonLife.transform.localPosition += new Vector3(0f, -300f, 0f);
        buttonRight.transform.localPosition += new Vector3(0f, -300f, 0f);
        buttonUp.transform.localPosition += new Vector3(0f, -300f, 0f);
        buttonAttack.transform.localPosition += new Vector3(300f, 0f, 0f);
        compass.transform.localPosition += new Vector3(0f, 700f, 0f);
        backpack.transform.localPosition += new Vector3(0f, 300f, 0f);
        exit.transform.localPosition -= new Vector3(0f, 300f * Screen.height / 1440f, 0f);
        dialog.transform.localPosition += new Vector3(700f, 0f, 0f);
        bScript.OpenBackpass();
        touch.enabled = false;
    }

    public void BackassButtonClose()
    {
        buttonLife.transform.localPosition -= new Vector3(0f, -300f, 0f);
        buttonRight.transform.localPosition -= new Vector3(0f, -300f, 0f);
        buttonUp.transform.localPosition -= new Vector3(0f, -300f, 0f);
        buttonAttack.transform.localPosition -= new Vector3(300f, 0f, 0f);
        compass.transform.localPosition -= new Vector3(0f, 700f, 0f);
        backpack.transform.localPosition -= new Vector3(0f, 300f, 0f);
        exit.transform.localPosition += new Vector3(0f, 300f * Screen.height / 1440f, 0f);
        dialog.transform.localPosition -= new Vector3(700f, 0f, 0f);
        bScript.CloseBackpass();
        touch.enabled = true;
    }
}
