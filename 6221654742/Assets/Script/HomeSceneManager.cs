using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceneManager : MonoBehaviour
{
    public void GoToPlayground()
    {
      SceneManager.LoadScene("Playground");
    }
    public void CountinuePlay()
    {
        if(PlayerPrefs.HasKey("PrevScene"))
        {
        string previousSceneName = PlayerPrefs.GetString("PrevScene");
        SceneManager.LoadScene(previousSceneName);
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
