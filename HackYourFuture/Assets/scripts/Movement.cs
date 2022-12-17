using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6f;

    float sensX;
    float sensY;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        float horizontal = Input.GetAxisRaw("Horizontal") * sensX;
        float vertical = Input.GetAxisRaw("Vertical") * sensY;

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        yRotation += horizontal;
        xRotation -= vertical;

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
