using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Менят материалы на объектах в зависимости от расположения игрока
 */

public class FonMaterial : MonoBehaviour
{
    public Material[] material;

    void OnTriggerStay(Collider fon)
    {
        if (fon.gameObject.tag == "Layer_1")
        {
            GetComponent<Renderer>().material = material[2];
        }
        else if (fon.gameObject.tag == "Layer_2")
        {
            GetComponent<Renderer>().material = material[1];
        }
    }
    void OnTriggerExit(Collider fon)
    {
        if (fon.gameObject.tag == "Layer_1" || fon.gameObject.tag == "Layer_2")
        {
            GetComponent<Renderer>().material = material[0];
        }
    }
}