using System.Data;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragging : MonoBehaviour
{
    private GameObject selectedObject;
    public CursorCamera CursorCamera;
    private Rigidbody selectedRigid;
    public GameObject Player;
    public DraggingExample draggingExample;

    private void Start()
    {
        draggingExample = GetComponent<DraggingExample>();
    }

    private void Update()
    {
        //Debug.Log(Camera.main.transform.forward);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("MouseDown");
            if (selectedObject == null)
            {
                Debug.Log("selected");
                RaycastHit hit = CastRay();
                if (hit.collider != null)
                {

                    Debug.Log("hit");
                    if (!hit.collider.CompareTag("Clone"))
                    {
                        Debug.Log("NotHit");
                        return;
                    }
                    Debug.Log("Happened");

                    GameObject item = hit.collider.gameObject;
                    spawntracker st = item.GetComponent<spawntracker>();
                    GameObject ogObject = st.itemIAm;
                    selectedObject = Instantiate(ogObject); // creating the object
                    draggingExample.PickUpObject(selectedObject); // this picks up the selected object

                    //selectedObject = hit.collider.gameObject;
                    //selectedRigid = selectedObject.GetComponent<Rigidbody>();
                    //if (selectedRigid  != null)
                    //{
                    //    selectedRigid.isKinematic = true;
                    //    selectedRigid.useGravity = false;

                    //}
                }
            }

        }

        else if (Input.GetMouseButtonUp(0))
        {
            if(selectedObject != null)
            {
                Debug.Log("UP");
                selectedObject = null;
            }
        }

        //else if (Input.GetMouseButtonUp(0))
        //{
        //    if (selectedObject != null)
        //    {
        //        Debug.Log("MouseUp");
        //        if (selectedRigid != null)
        //        {
        //            selectedRigid.isKinematic = false;
        //            selectedRigid.useGravity = true;
        //        }
        //        selectedObject.transform.SetParent(null);
        //        selectedObject = null;
        //    }
        //}
        //if (selectedObject != null)
        //{
        //    Debug.Log("PICKED");
        //    selectedObject.transform.SetParent(Player.transform);
            
        //} 
    }

    private RaycastHit CastRay()
    {
       
        RaycastHit hit;
        Debug.Log(Camera.main);
        Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit);

        return hit;
    }
}

