using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadDevelopers()
    {
        SceneManager.LoadScene("Developers"); 
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene("Start Screen"); 
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Options"); 
    }

    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay"); 
    }
}
