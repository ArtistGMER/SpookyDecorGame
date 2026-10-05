using UnityEngine;

public class DraggingExample : MonoBehaviour
{
    public GameObject selectedObject;
    public Vector3 positionHeld;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit = CastRay();
            if (hit.collider.gameObject.CompareTag("Drag"))
            {
                PickUpObject(hit.collider.gameObject);
            }
        }

        if(selectedObject != null)
        {
            // Calculating the position a little forward from the camera position
            Vector3 forwardPosition = Camera.main.transform.position + (Camera.main.transform.forward*3);

            selectedObject.transform.position = forwardPosition; // this forces the position of it, the rotation, etc. But once its let go of [ set to null] gravity takes over it again. Thats why it falls down
            selectedObject.transform.rotation = Quaternion.identity;    
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (selectedObject != null)
            {
                selectedObject = null;
            }

        }
    }

    public void PickUpObject(GameObject newObject)
    {
        selectedObject = newObject;
    }


    private RaycastHit CastRay()
    {

        RaycastHit hit;
        Debug.Log(Camera.main);
        Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit);
        return hit;
    }
}
