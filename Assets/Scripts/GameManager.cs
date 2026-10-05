using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;


public class GameManager : MonoBehaviour
{
    public List<GameObject> DecorObjects;
    private Vector3 mousePosition;
    private Vector3 startPosition;

    //public CursorCamera CursorCamera;
    //public Transform SpawnHere;
    //private int currentItemIndex = 0;

   
    
 
    void Start()
    {
        
        
    }
    
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //Instantiate(DecorObjects, startPosition, Quaternion.identity);


        }
    }

    //void SpawnItem()
    //{
    //    GameObject objectSpawn = DecorObjects[currentItemIndex];

    //    Instantiate(objectSpawn, SpawnHere.position, SpawnHere.rotation);
    //    Debug.Log("Spawned" + objectSpawn.name);
    //    currentItemIndex = (currentItemIndex + 1) % DecorObjects.Count;

        
    //}
}

