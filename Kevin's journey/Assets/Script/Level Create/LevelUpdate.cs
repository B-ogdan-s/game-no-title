using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * �������� ������� ���� ��� �� ��� �� ������ ������
 */

public class LevelUpdate : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PlayerFon")
        {
            transform.localPosition -= new Vector3(0f, 30f, 0f);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "PlayerFon")
        {
            transform.localPosition += new Vector3(0f, 30f, 0f);
        }
    }
}
