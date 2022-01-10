using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportPos : MonoBehaviour
{
    GameObject player, cam;

    public string namScene;
    void Start()
    {
        if (PlayerPrefs.GetInt("Check") == 0)
        {
            if (PlayerPrefs.GetString("NamLoc") == namScene)
            {
                player = GameObject.Find("Player");
                cam = GameObject.Find("Player Coordinates");
                player.transform.localPosition = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
                PlayerPrefs.SetInt("Check", 1);
            }
            else
            {
                SceneManager.LoadScene(PlayerPrefs.GetString("NamLoc"));
            }
        }
        else
        {
            PlayerPrefs.SetString("NamLoc", "StartLocation (0;0)");
            PlayerPrefs.SetFloat("PosX", 0);
            PlayerPrefs.SetFloat("PosY", 1);
            PlayerPrefs.SetFloat("PosZ", 0);
            PlayerPrefs.SetInt("Check", 0);
            SceneManager.LoadScene(PlayerPrefs.GetString("NamLoc"));
        }
    }
}
