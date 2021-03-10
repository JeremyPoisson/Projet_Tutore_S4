using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    /*public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/

    public void BackGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene("Menu");
    }

    /*public void LoadMenu1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadMenu2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void LoadMenu3()
    {
        SceneManager.LoadScene("Level3");
    }*/
}
