using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class piecesScript : MonoBehaviour
{
    Vector3 RightPoisition;
    public bool InRightPosition;
    public bool Selected;

    void Start()
    {
        //Randomizes pieces on the right side 
        RightPoisition = transform.position; //saves the original position
        //then moves the pieces into random spots on right side
        //transform.position = new Vector3(Random.Range(-4f, 3f), Random.Range(6f, -2f)); 
        transform.position = new Vector3(Random.Range(540f, 780f), Random.Range(430f, 160f));
    }

    void Update()
    {
        //this snaps the puxxle pieces into place
        //Vector3.Distance is distrance between two positions
        //was < 0.5f
        if (Vector3.Distance(transform.position, RightPoisition) < 0.5f)
        {
            if (!Selected)
            {
                if (InRightPosition == false) //so code doesn't run every frame
                {                
                    //auto moves piece to final place
                    transform.position = RightPoisition;
                    //sets the bool to true to check in additional code
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                }

            }

        }

    }
}
