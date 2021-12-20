using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGraundCreate : MonoBehaviour
{
    public GameObject[] graundUp;
    public GameObject graund;
    public int numX, numY, numZ;

    void Start()
    {
        BoxCollider col =  GetComponent<BoxCollider>();

        numX = (int)(transform.localScale.x / 1.5f);
        numY = (int)(transform.localScale.y / 1.5f);
        numZ = (int)(transform.localScale.z / 1.5f);

        for (int y = 0; y < numY; y++)
        {
            for (int x = 0; x < numX; x++)
            {
                for (int z = 0; z < numZ; z++)
                {
                    if (y == 0)
                    {
                        int i = RandomPosition();
                        graundUp[i].transform.localPosition = new Vector3(transform.localPosition.x - (transform.localScale.x / 2f - 0.75f) + x * 1.5f,
                                                                          transform.localPosition.y + (transform.localScale.y / 2f - 0.75f),
                                                                          transform.localPosition.z - (transform.localScale.z / 2f - 0.75f) + z * 1.5f);
                        Instantiate(graundUp[i]);
                    }
                    else
                    {
                        graund.transform.localPosition = new Vector3(transform.localPosition.x - (transform.localScale.x / 2f - 0.75f) + x * 1.5f,
                                                                          transform.localPosition.y  + (transform.localScale.y / 2f - 0.75f) + (-y * 1.5f),
                                                                          transform.localPosition.z - (transform.localScale.z / 2f - 0.75f) + z * 1.5f);
                        Instantiate(graund);
                    }
                }
            }
        }
        Destroy(gameObject);
    }

    public int RandomPosition()
    {
        return (Random.Range(0, graundUp.Length));
    }
}
