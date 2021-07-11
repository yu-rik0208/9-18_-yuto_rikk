using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{
    private Transform CameraTransform;
    private Vector3 CameraRotation;

    public float MouseSensitivity;
    public Vector2 MaxMinAngle;

    // Start is called before the first frame update
    void Start()
    {
        CameraTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        var tmp_MouseX = Input.GetAxis("Mouse X");
        var tmp_MouseY = Input.GetAxis("Mouse Y");
        //CameraRotation.x += tmp_MouseY * MouseSensitivity;
        CameraRotation.x = Mathf.Clamp(CameraRotation.x, MaxMinAngle.x, MaxMinAngle.y);
        CameraRotation.y -= tmp_MouseX * MouseSensitivity;

        CameraTransform.rotation = Quaternion.Euler(CameraRotation.x,CameraRotation.y,0);
    }
}
