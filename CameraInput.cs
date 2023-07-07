using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInput : MonoBehaviour
{
    [SerializeField] private float sensitivityMouse = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void adjustAngleCamera()
    {
        float verticalRotation = this.transform.localEulerAngles.x;
        verticalRotation -= Input.GetAxis("Mouse Y")*sensitivityMouse;
        if(45 <=verticalRotation && verticalRotation <= 315) {
            if(315 < verticalRotation+40) {
                verticalRotation = 315;
            }
            else {
                verticalRotation = 45;
            }
        }
        this.transform.localEulerAngles = new Vector3(verticalRotation, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        adjustAngleCamera();
    }
}
