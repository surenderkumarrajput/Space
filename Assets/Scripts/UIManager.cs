using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Scripts responsible for UI management of overall game
public class UIManager : MonoBehaviour
{
    //Function for changing scene.
    public void SceneChange(string sceneName)
    {
        FindObjectOfType<AudioManager>().Play("Tap");
        SceneManager.LoadScene(sceneName);
    }

    //Function for application quit.
    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("Tap");
        Application.Quit();
    }
}
