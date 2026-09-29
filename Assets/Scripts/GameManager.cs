using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;


public class GameManager : MonoBehaviour
{
    public List<GameObject> DecorObjects;
    private bool isDragging;
    private Vector3 mousePosition;
    private Vector3 startPosition;

    public CursorCamera CursorCamera;
    public Transform SpawnHere;
    private int currentItemIndex = 0;

    public GameObject Platform;
    
 
    void Start()
    {
        
        
    }
    private Vector3 GetMousePos()
    {
        return CursorCamera.MainCamera.WorldToScreenPoint(transform.position);
    }
    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        isDragging = true;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            transform.position = CursorCamera.MainCamera.ScreenToWorldPoint(mousePos);

        }
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(CursorCamera.transform.position, CursorCamera.transform.forward, out RaycastHit hit, 10))
            {
                //Debug.Log(hit.point.transform.name);


            }
        }
        if (Keyboard.current.digit1Key.wasPressedThisFrame && Input.GetMouseButtonDown(0))
        {
            currentItemIndex = 1;
            SpawnItem();
        }
        if (Keyboard.current.digit2Key.wasPressedThisFrame && Input.GetMouseButtonDown(0))
        {
            currentItemIndex = 2;
            SpawnItem();
        }
    }

    void SpawnItem()
    {
        GameObject objectSpawn = DecorObjects[currentItemIndex];

        Instantiate(objectSpawn, SpawnHere.position, SpawnHere.rotation);
        Debug.Log("Spawned" + objectSpawn.name);
        currentItemIndex = (currentItemIndex + 1) % DecorObjects.Count;

        
    }
}

