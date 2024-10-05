using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoaderCallBack : MonoBehaviour
{
    float timer;
    private void Start()
    {
         timer = 0f;
    }
    void Update()
    {
        Debug.Log(Datainfo.GoScene);
        Debug.Log(timer);
        timer += Time.deltaTime;
        if (timer >= 0.5f)
        {
            if (Datainfo.GoScene == 1)
            {
                SceneManager.LoadScene("GamePlay");
            }
            else if (Datainfo.GoScene == 2)
            {
                SceneManager.LoadScene("StartMenu");
            }
            timer = 0f;
        }
    }
}
