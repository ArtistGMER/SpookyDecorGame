using UnityEngine;
using UnityEngine.InputSystem;

public class WASDCamera : MonoBehaviour
{
    public Camera TopView;
    public Camera ThreeFourthView;
    public Camera SideView;
    public Camera SecondView;
    public float sensitivity = 1000f;
    public float yPos;
    public float xPos;
    
    void Start()
    {
        TopView.enabled = true;
    }

    void Update()
    {
        //when A is pressed, turn camera on the Positive X Axis. when D Is pressed, turn camera on the Negative X axis. When W is pressed, tilt camera
        // on the Positive Y Axis. When S is pressed, tilt camera on the Negative Y Axis. W would only be able to take to to the top view at the max
        // the D will bring you to a front view
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            TopView.enabled = true;
            SideView.enabled = false;
            ThreeFourthView.enabled = false;
            SecondView.enabled = false;
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            TopView.enabled = false;
            SideView.enabled = true;
            ThreeFourthView.enabled = false;
            SecondView.enabled = false;
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            TopView.enabled = false;
            SideView.enabled = false;
            ThreeFourthView.enabled = true;
            SecondView.enabled = false;
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            TopView.enabled = false;
            SideView.enabled = false;
            ThreeFourthView.enabled = false;
            SecondView.enabled = true;
        }

    }
}
