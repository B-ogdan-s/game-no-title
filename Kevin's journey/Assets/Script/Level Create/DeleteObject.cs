using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Удаляет меш после того как в нём были созданы все объекты
 */

public class DeleteObject : MonoBehaviour
{
    void Start()
    {
        Destroy(this);
    }
}
