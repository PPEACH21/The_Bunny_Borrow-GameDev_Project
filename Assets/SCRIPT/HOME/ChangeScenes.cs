using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void Play()
    {
        Datainfo.GoScene = 1;
        SceneManager.LoadScene("LoadingScene");
    }

    public void Setting()
    {
        SceneManager.LoadScene("OptionUI");
    }

    public void BacktoHome()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
