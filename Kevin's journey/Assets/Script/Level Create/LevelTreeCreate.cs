using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTreeCreate : MonoBehaviour
{
    public GameObject tree;
    public int numX, numZ;

    void Start()
    {
        BoxCollider col = GetComponent<BoxCollider>();

        numX = (int)(transform.localScale.x / 1.5f);
        numZ = (int)(transform.localScale.z / 1.5f);

        for (int z = 0; z < numZ; z++)
        {
            for (int x = 0; x < numX; x++)
            {
                tree.transform.localPosition = new Vector3(transform.localPosition.x - (transform.localScale.x / 2f - 0.75f) + x * 1.5f,
                                                                          transform.localPosition.y - (transform.localScale.y / 2f),
                                                                          transform.localPosition.z - (transform.localScale.z / 2f - 0.75f) + z * 1.5f);

                tree.transform.rotation = Quaternion.Euler(0f, RandomRot() * 90, 0f);
                Instantiate(tree);
            }
        }
        Destroy(gameObject);
    }
    public int RandomRot()
    {
        return (Random.Range(0, 4));
    }
}
