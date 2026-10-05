using UnityEngine;
using UnityEngine.EventSystems;

public class NewMonoBehaviourScript : MonoBehaviour 
{
    private Vector3 startingPosition;
    private Vector3 mousePosition;
    public CursorCamera MainCamera;
    void Start()
    {
        startingPosition = transform.position;
       // CursorCamera.MainCamera.MainCamera = MainCamera.Camera; 
    }

    void Update()
    {
        
    }
}
