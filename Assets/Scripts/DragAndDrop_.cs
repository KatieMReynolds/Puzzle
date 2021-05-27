using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop_ : MonoBehaviour
{
    public GameObject SelectedPiece;
    int OIL = 1; //order in layer
    
    //Start is enabled before any Update methods and called only once
    void Start()
    {
        
    }

    //Update is called every frame
    void Update()
    {
        //Transform -> All objects have a transform, used to store and manipulate position, rotation, and scale of object. Can be used with inheritance. 
        //Comparetag?
        //Raycast -> Detect objects that lie on path of a ray like firing laser beam into a scene to see which objects are hit by it (Colliders). Returns null is nothing is hit. 
        //Raycasthit -> Structure used to get info back from a raycast
        //Physics2D
        //ScreenToWorldPoint
        //Vector2/3 ->A

        //if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            //hit is the new raycast now looking for a collider following the pointer
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            Debug.Log(hit.transform.gameObject);
            //If the raycast hits a collider with the tag "Puzzle" then 
            if (hit.transform.CompareTag("Puzzle"))
            {
                //this if statement added from piecesScript. This checks if pieces are in their final position
                //Only allows pieces to be moved if not in their home/final spot
                if (!hit.transform.GetComponent<piecesScript>().InRightPosition)
                {
                    //gameObject ->the game object this component this is attached to
                    //sets the selected piece as the collider in the path of the raycast when mouse is clicked
                    SelectedPiece = hit.transform.gameObject;

                    SelectedPiece.GetComponent<piecesScript>().Selected = true;
                    //OIL with the sorting group makes the selected piece appear on top of the other pieces
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }
            }
        }

        //deselects the piece
        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<piecesScript>().Selected = false;
                SelectedPiece = null;
            }


        }
        //If the raycast hits a collider and has a game object attached to it
        if (SelectedPiece != null)
        {
            //Get the mouse position
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Set the position of the selectedPiece to the mouse position
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
