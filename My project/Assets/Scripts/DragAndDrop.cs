using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//raycasting!!

//void functions dont return anything! thats why we r making a vector3

public class DragAndDrop : MonoBehaviour
{
    public LayerMask draggableMask;
    GameObject selectedObject;
    bool isDragging;


    // Start is called before the first frame update
    void Start()
    {
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);
            //camera.main is the main cmera, SPTR takes the mouse pos into a 3d ray

            RaycastHit2D hit = Physics2D.Raycast(rayCast.origin, rayCast.direction, Mathf.Infinity, draggableMask);
            //cast an array from where the mouse is at striaght into the screen from/for long distance and only for the drag mask

            if (hit.collider != null) {
                //hit.colleder is any collder the ray hits
                Debug.Log(hit.collider.gameObject.name);

                selectedObject = hit.collider.gameObject;
                isDragging = true;
            }
            
        }

        if (isDragging)
        {
            Vector3 position = mousePos();
            selectedObject.transform.position = position;
            //the objects position will be at the mouse position

            if (selectedObject.CompareTag("Broom"))
            {
                Debug.Log("I touched the broom");
            }
        }

        //not clicking anymore
        if (Input.GetMouseButtonUp(0)) 
        {
            isDragging = false;
        }
    }

    // this will return a mouse position value
    Vector3 mousePos()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        //this will give us mouse postiion in a worl point..10 is cuz cam is 1 units wy
    }
}
