using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * ��������� ������ �� ������ �����
 */

public class TeleportScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(PlayerPrefs.GetString("NamLoc"));
            PlayerPrefs.SetInt("Check", 0);
        }
    }
}
