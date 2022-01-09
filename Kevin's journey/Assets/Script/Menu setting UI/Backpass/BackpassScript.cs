using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Создаёт меню инвентаря
 */

public class BackpassScript : MonoBehaviour
{
    public GameObject slotInventory, fon;
    GameObject objSlot, objFon, player;

    GameObject[] masBackpass;
    GameObject[] maseQuipment = new GameObject[5];
    public Transform canvas;
    public int num = 3;
    float startPosX, startPosY, scaleX, scaleY;

    public void OpenBackpass()
    {
        player = GameObject.Find("Player");
        masBackpass = new GameObject[num];
        scaleX = Screen.width / 2960f;
        scaleY = Screen.height / 1440f;
        startPosX = scaleX * 25f;
        startPosY = scaleY * 350f;


        objFon = Instantiate(fon) as GameObject;
        objFon.transform.SetParent(canvas);
        objFon.transform.localScale = new Vector3(scaleX, scaleY, 1f);
        objFon.transform.localPosition = new Vector3(-50 * scaleX, 0f, 0f);
        objFon.transform.rotation = Quaternion.Euler(0f, player.transform.localRotation.eulerAngles.y, 0f);

        for (int j = 0; j<3; j++)
        {
            if (j * 4 >= num)
                break;
            for (int i = 0; i<4; i++)
            {
                if (j * 4 + i >= num)
                    break;
                objSlot = Instantiate(slotInventory) as GameObject;
                objSlot.transform.SetParent(canvas);
                objSlot.transform.localScale = new Vector3(scaleX, scaleX, 1f);
                objSlot.transform.localPosition = new Vector3(startPosX + i * 350f * scaleX, startPosY - j * 350f * scaleY, 0f);
                objSlot.transform.rotation = Quaternion.Euler(0f, player.transform.localRotation.eulerAngles.y, 0f);
                masBackpass[j * 4 + i] = objSlot;
            }
        }

        for(int i = 0; i<2; i++)
        {
            objSlot = Instantiate(slotInventory) as GameObject;
            objSlot.transform.SetParent(canvas);
            objSlot.transform.localScale = new Vector3(scaleX, scaleX, 1f);
            objSlot.transform.localPosition = new Vector3(-1175 * scaleX + i * (350f * 2f) * scaleX, 500 * scaleY, 0f);
            objSlot.transform.rotation = Quaternion.Euler(0f, player.transform.localRotation.eulerAngles.y, 0f);
            maseQuipment[i] = objSlot;
        }

        for (int i = 0; i < 3; i++)
        {
            objSlot = Instantiate(slotInventory) as GameObject;
            objSlot.transform.SetParent(canvas);
            objSlot.transform.localScale = new Vector3(scaleX, scaleX, 1f);
            objSlot.transform.localPosition = new Vector3(-1175 * scaleX + i * 350f * scaleX, -500 * scaleY, 0f);
            objSlot.transform.rotation = Quaternion.Euler(0f, player.transform.localRotation.eulerAngles.y, 0f);
            maseQuipment[i + 2] = objSlot;
        }
    }

    public void CloseBackpass()
    {
        Destroy(objFon);

        for (int i = 0; i < num; i++)
        {
            Destroy(masBackpass[i]);
        }
        masBackpass = new GameObject[0];

        for (int i = 0; i < 5; i++)
        {
            Destroy(maseQuipment[i]);
        }
        maseQuipment = new GameObject[5];
    }
}
