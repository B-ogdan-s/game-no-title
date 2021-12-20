using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpassButtonClick : MonoBehaviour
{
    public GameObject buttonLife, buttonRight, compass, buttonUp, backpack, exit;
    public CamTouch touch;
    public BackpassScript bScript;

    public void BackassButtonOpen()
    {
        buttonLife.transform.localPosition += new Vector3(0f, -300f, 0f);
        buttonRight.transform.localPosition += new Vector3(0f, -300f, 0f);
        buttonUp.transform.localPosition += new Vector3(0f, -300f, 0f);
        compass.transform.localPosition += new Vector3(0f, 700f, 0f);
        backpack.transform.localPosition += new Vector3(0f, 300f, 0f);
        exit.transform.localPosition -= new Vector3(0f, 300f * Screen.height / 1440f, 0f);
        bScript.OpenBackpass();
        touch.enabled = false;
    }

    public void BackassButtonClose()
    {
        buttonLife.transform.localPosition -= new Vector3(0f, -300f, 0f);
        buttonRight.transform.localPosition -= new Vector3(0f, -300f, 0f);
        buttonUp.transform.localPosition -= new Vector3(0f, -300f, 0f);
        compass.transform.localPosition -= new Vector3(0f, 700f, 0f);
        backpack.transform.localPosition -= new Vector3(0f, 300f, 0f);
        exit.transform.localPosition += new Vector3(0f, 300f * Screen.height / 1440f, 0f);
        bScript.CloseBackpass();
        touch.enabled = true;
    }
}
