using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    // Start is called before the first frame update
    public float lenghtOfTheDayInSec;
    float currenrTime;
    public Light sunObject;
    public GameObject[] lights;
    bool isDay;

    void Start()
    {
        currenrTime = lenghtOfTheDayInSec / 4;
        isDay = false;
    }

    // Update is called once per frame
    void Update()
    {
        currenrTime += Time.deltaTime;

        if (currenrTime >= lenghtOfTheDayInSec)
        {
            currenrTime -= lenghtOfTheDayInSec ;
        }
        if (currenrTime >= 0 && currenrTime <= lenghtOfTheDayInSec / 2)
        {
            foreach (GameObject light in lights)
            {
                Light lightComponent = light.GetComponent<Light>();
                if (lightComponent != null)
                {
                    lightComponent.enabled = false;
                }
            }
        }
        else
        {
            foreach (GameObject light in lights)
            {
                Light lightComponent = light.GetComponent<Light>();
                if (lightComponent != null)
                {
                    lightComponent.enabled = true;
                }
            }
        }

        float sunAngle = (360 / lenghtOfTheDayInSec) * currenrTime;
        
        sunObject.transform.localRotation = Quaternion.Euler(sunAngle, -33, 0);

    }
}
