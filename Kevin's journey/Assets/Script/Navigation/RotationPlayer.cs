using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlayer : MonoBehaviour
{
    public float speedRotCam;
    public int numQueue = 0, rotNum = 0;
    public int[] queueRot = new int[0];
    public bool startRot = false;

    void Update()
    {
        if(numQueue != 0)
        {
            if(rotNum == 4)
            {
                rotNum = 0;
            }
            if(rotNum < 0)
            {
                rotNum += 4;
            }

            if(startRot == false)
            {
                rotNum += queueRot[0];
                startRot = true;
            }
            else if(transform.localRotation.eulerAngles.y > (rotNum * 90) - 4f && transform.localRotation.eulerAngles.y < (rotNum * 90) + 4f && startRot == true)
            {
                transform.rotation = Quaternion.Euler(0f, rotNum * 90, 0f);
                ReduceMas();
                Alignment();
                startRot = false;
            }
            else
            {
                transform.Rotate(0f, speedRotCam * queueRot[0], 0f);
            }
        }
    }

    public void ReduceMas()
    {
        int[] oldMas = queueRot;

        numQueue--;
        queueRot = new int[numQueue];
        for(int i = 0; i<numQueue; i++)
        {
            queueRot[i] = oldMas[i + 1];
        }
    }

    public void Alignment()
    {

        if ((rotNum + 1) % 2 == 1)
        {
            int n = AlignmentMath(transform.localPosition.z);

            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, n * 1.5f);
        }
        else if ((rotNum + 1) % 2 == 0)
        {
            int n = AlignmentMath(transform.localPosition.x);

            transform.localPosition = new Vector3(n * 1.5f, transform.localPosition.y, transform.localPosition.z);
        }
    }

    public int AlignmentMath(float pos)
    {
        int n;
        n = (int)(pos / 1.5f);
        if (Mathf.Abs(pos % 1.5f) >= 0.75)
        {
            if (pos > 0)
                n++;
            else if (pos < 0)
                n--;
        }
        return n;
    }
}
