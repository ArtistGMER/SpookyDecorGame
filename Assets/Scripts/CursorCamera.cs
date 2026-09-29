using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class CursorCamera : MonoBehaviour
{

    public float Speed = 1;
    public float zpos;
    public GameObject mover;
    public Vector3 MovingCam;
    public float sensitivity = 1000f;
    public Camera MainCamera;
    public Vector3 turn;

    void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(turn.y, -turn.x, 0);

        MovingCam = Vector3.zero;
        MovingCam += transform.forward * (Input.GetAxisRaw("Vertical")) * Speed * Time.deltaTime;
        MovingCam += transform.right * (Input.GetAxisRaw("Horizontal")) * Speed * Time.deltaTime;
        //MovingCam = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * Speed * Time.deltaTime;
        mover.transform.Translate(MovingCam); 

        
    }


    
}
