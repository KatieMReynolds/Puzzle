using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class puzzleSelect : MonoBehaviour
{
    public GameObject StartPanel;
    public void SetPuzzlesPhoto(Image Photo)
    {
        //TO DO: GET THE SELECTED SCENE AND SEND THAT DATA TO THE NEXT SCENE

        //assigns parts of the puzzle image to the corresponding pieces
        for (int i= 0; i < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        StartPanel.SetActive(false);
        SceneManager.LoadScene(2);//loads next scene
    }

}
