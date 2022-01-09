using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * проверяет чи есть по близости NPS и если есть появляется кнопка для начала диалога
 */

public class DialogScript : MonoBehaviour
{
    public OutputDialogNPS manager;
    GameObject dialogButton;

    public void Start()
    {
        dialogButton = GameObject.Find("Dialog");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "NPS")
        {
            dialogButton.transform.localPosition -= new Vector3(1000f * Screen.width / 2960f, 0f, 0f);
            manager.textDealog = other.GetComponent<TextDialogNPS>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "NPS")
        {
            dialogButton.transform.localPosition += new Vector3(1000f * Screen.width / 2960f, 0f, 0f);
            manager.textDealog = null;
        }
    }
}
