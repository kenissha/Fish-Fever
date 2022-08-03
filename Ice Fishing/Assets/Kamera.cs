using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;

public class Kamera : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed = 0.1f;

    [Header("Camera Position")]
    public float cameraPositionX;
    public float cameraPositionY;
    public float cameraPositionZ;

    [Header("Camera Rotation")]
    public float cameraRotationX;
    public float cameraRotationY;
    public float cameraRotationZ;




    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(cameraRotationX, cameraRotationY, cameraRotationZ);
        transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x + cameraPositionX, target.position.y + cameraPositionY, target.position.z + cameraPositionZ), cameraSpeed);
    }

}