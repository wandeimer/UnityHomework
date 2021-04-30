using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform myObject;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Instantiate(myObject, new Vector3(i * .2F, 1 + (j* .2F), 0 + (k * .2F)), Quaternion.identity);
                }
            }
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
