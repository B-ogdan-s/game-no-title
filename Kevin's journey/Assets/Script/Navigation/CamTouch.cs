using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * —читывает нажати€ на экран
 */

public class CamTouch : MonoBehaviour
{
    Vector2 startToush, finishToush;
    RotationPlayer rotCam;
    float time = 0f;

    void Start()
    {
        rotCam = GameObject.Find("Player").GetComponent<RotationPlayer>();
    }

    void FixedUpdate()
    {
        time++;

        /*
         * проверка на нажатие
         */
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // проверка на касание
            if (touch.phase == TouchPhase.Began)
            {
                startToush = Input.GetTouch(0).position;
            }

            // проверка на удерживание
            if (touch.phase == TouchPhase.Moved)
            {
                
            }

            // проверка на отпуск
            if (touch.phase == TouchPhase.Ended)
            {
                if (time >= 10)
                {
                    finishToush = Input.GetTouch(0).position;
                    DirectionOfRotation();

                    finishToush = new Vector2(0f, 0f);
                    startToush = new Vector2(0f, 0f);
                    time = 0;
                }
            }
        }
        /*
         * если нет нажати€
         */
        else
        {
            
        }
    }

    public void DirectionOfRotation()
    {
        if (Mathf.Abs(finishToush.x - startToush.x) >= 100f)
        {
            if (finishToush.x > startToush.x)
            {
                AddMas();
                rotCam.queueRot[rotCam.numQueue - 1] = -1;
            }
            else if (finishToush.x < startToush.x)
            {
                AddMas();
                rotCam.queueRot[rotCam.numQueue - 1] = 1;
            }
        }
    }

    public void AddMas()
    {
        int[] oldMas = rotCam.queueRot;

        rotCam.numQueue++;
        rotCam.queueRot = new int[rotCam.numQueue];

        for (int i = 0; i < rotCam.numQueue - 1; i++)
        {
            rotCam.queueRot[i] = oldMas[i];
        }
    }
}
