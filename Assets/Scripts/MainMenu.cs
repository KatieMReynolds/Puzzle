using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        ///can use a scene name in ("Scene01") or (1) 1 being the load index
        ///SceneManager.LoadScene(1);
        //Next Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //For testing in unity engine
        Debug.Log("QUIT");
        //close the game
        Application.Quit();
    }

    public void ToMain()
    {
        SceneManager.LoadScene(1);
    }

    public void BackScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ToGameScene()
    {
        SceneManager.LoadScene(2);
    }
}
