using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 5;
        float rotateSpeed = 0.2f;
        float horisontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float tiltAroundZ = -Input.GetAxis("Horizontal") * rotateSpeed;


        transform.Translate(new Vector3(verticalInput, 0, 0) * moveSpeed * Time.deltaTime);
        transform.Rotate(0.0f, 0.0f, tiltAroundZ);
    }
}
