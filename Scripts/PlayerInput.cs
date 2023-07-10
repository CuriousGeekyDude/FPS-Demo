using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float sensitivityMouse = 9.0f;
    [SerializeField] private float speed = 6.0f;
    [SerializeField] private CharacterController charController;
    [SerializeField] private float gravity = 0f;
    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }
    void adjustAnglePlayer()
    {
        float horizontalRotation = this.transform.localEulerAngles.y;
        horizontalRotation += Input.GetAxis("Mouse X")*sensitivityMouse;
        this.transform.localEulerAngles = new Vector3(0, horizontalRotation, 0);
    }

    void keyboardInput()
    {
        float horizontalChange = (Input.GetAxis("Horizontal")*speed)*Time.deltaTime;
        float verticalChange = (Input.GetAxis("Vertical")*speed)*Time.deltaTime;
        Vector3 movement = new Vector3(horizontalChange, gravity*Time.deltaTime, verticalChange);

        movement = this.transform.TransformDirection(movement);
        charController.Move(movement);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        adjustAnglePlayer();
        keyboardInput();
    }
}
