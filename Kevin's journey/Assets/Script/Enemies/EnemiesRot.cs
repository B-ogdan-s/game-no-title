using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ������������ ������ ����� ��� �� ��� ��� ��������� ������
 */
public class EnemiesRot : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, player.transform.localRotation.eulerAngles.y, 0f);
    }
}
