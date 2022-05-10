using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public string NameScene;
    
    public void ChangeS()
    {
        SceneManager.LoadScene(NameScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
