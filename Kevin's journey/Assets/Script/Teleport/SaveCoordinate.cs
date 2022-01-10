using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCoordinate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Сохранить координаты для телепортации");
        }
    }
}
