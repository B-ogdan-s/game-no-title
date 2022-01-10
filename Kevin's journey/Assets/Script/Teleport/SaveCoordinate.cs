using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * сохраняет координаты куда переместится игрок.
 */

public class SaveCoordinate : MonoBehaviour
{
    public string nam, nam_1;
    public float posX, posY, posZ, posX_1, posY_1, posZ_1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            nam_1 = PlayerPrefs.GetString("NamLoc");
            posX_1 = PlayerPrefs.GetFloat("PosX");
            posY_1 = PlayerPrefs.GetFloat("PosY");
            posZ_1 = PlayerPrefs.GetFloat("PosZ");

            PlayerPrefs.SetString("NamLoc", nam);
            PlayerPrefs.SetFloat("PosX", posX);
            PlayerPrefs.SetFloat("PosY", posY);
            PlayerPrefs.SetFloat("PosZ", posZ);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (nam_1 != null)
            {
                PlayerPrefs.SetString("NamLoc", nam_1);
                PlayerPrefs.SetFloat("PosX", posX_1);
                PlayerPrefs.SetFloat("PosY", posY_1);
                PlayerPrefs.SetFloat("PosZ", posZ_1);
            }
        }
    }
}
