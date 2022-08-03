using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody controller;
    public float ivme;



    private void Start()
    {

        controller = GetComponent<Rigidbody>();


    }

    public float speed = 6;
    public float turnSmoothTime = 0.1f;
    public float turnSmoothVelocity;

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //Yatay yön
        float vertical = Input.GetAxisRaw("Vertical"); //Dikey yön
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized; //Gideceðimiz yön

        if (direction.magnitude >= 0.1)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg; //Karakterin vücüdunu çevirme
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);
            speed += ivme * Time.deltaTime;
            controller.velocity= (direction * speed * Time.deltaTime); //Hareket et
        }
    }
}