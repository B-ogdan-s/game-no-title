using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * двигает врага от одной точки к друг в определённой последовательности 
 */

public class EnemiesTraffic : MonoBehaviour
{
    public GameObject[] check;
    public int directionCheck, numCheck, dirX, dirY, step;
    public float speed;

    void Start()
    {
        numCheck = check.Length;
        Direction();
    }

    void FixedUpdate()
    {
        if(Radius() < 0.1f)
        {
            Navigation();
            transform.localPosition = new Vector3(check[directionCheck].transform.localPosition.x, transform.localPosition.y, check[directionCheck].transform.localPosition.z);
            directionCheck += step;
            Direction();
        }
        transform.localPosition += new Vector3(dirX * (speed * Time.deltaTime), 0f, dirY * (speed * Time.deltaTime));
    }

    public void Direction()
    {
        if (transform.localPosition.x == check[directionCheck].transform.localPosition.x)
        {
            dirX = 0;
            if(transform.localPosition.z > check[directionCheck].transform.localPosition.z)
            {
                dirY = -1;
            }
            else if (transform.localPosition.z < check[directionCheck].transform.localPosition.z)
            {
                dirY = 1;
            }
        }
        else if(transform.localPosition.z == check[directionCheck].transform.localPosition.z)
        {
            dirY = 0;
            if (transform.localPosition.x > check[directionCheck].transform.localPosition.x)
            {
                dirX = -1;
            }
            else if (transform.localPosition.x < check[directionCheck].transform.localPosition.x)
            {
                dirX = 1;
            }
        }
    }

    public float Radius()
    {
        float x, y;
        x = transform.localPosition.x - check[directionCheck].transform.localPosition.x;
        y = transform.localPosition.z - check[directionCheck].transform.localPosition.z;
        return Mathf.Sqrt(x * x + y * y);
    }

    public void Navigation()
    {
        if(step == 1 && numCheck-1 == directionCheck)
        {
            step = -1;
        }
        else if (step == -1 && 0 == directionCheck)
        {
            step = 1;
        }
    }
}
