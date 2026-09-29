using UnityEngine;
using UnityEngine.EventSystems;

public class Dragging : MonoBehaviour
{
    private GameObject selectedObject;
    public CursorCamera CursorCamera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(selectedObject == null)
            {
                RaycastHit hit = CastRay();
                if (hit.collider != null)
                {
                    if (!hit.collider.CompareTag("Drag"))
                    {
                        return;
                    }

                    selectedObject = hit.collider.gameObject;
                    Cursor.visible = false;
                }
            }
            else
            {

            }
        }
        if (selectedObject != null)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, CursorCamera.MainCamera.WorldToScreenPoint(selectedObject.transform.position).z);
            Vector3 worldPosition = CursorCamera.MainCamera.ScreenToViewportPoint(position);
            selectedObject.transform.position = new Vector3(worldPosition.x, .25f, worldPosition.z);
        }
    }

    private RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, CursorCamera.MainCamera.farClipPlane);
        Vector3 screenMousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, CursorCamera.MainCamera.farClipPlane);
        Vector3 worldMousePosFar = CursorCamera.MainCamera.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = CursorCamera.MainCamera.ScreenToWorldPoint(screenMousePosNear);
        RaycastHit hit;
        Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);

        return hit;
    }
}

