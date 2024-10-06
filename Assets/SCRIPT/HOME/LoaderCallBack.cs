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
                Datainfo.timeRemaining = Datainfo.timeDafault;
                SPAT1.hasSpawned = false;
                SPAT2.hasSpawned = false;
                SPAT3.hasSpawned = false;
                SPAT4.hasSpawned = false;
                SpawnOrder1.hasSpawned = false;
                SpawnOrder2.hasSpawned = false;
                SpawnOrder3.hasSpawned = false;
                SpawnOrder4.hasSpawned = false;
                FSP1.hasSpawned = false;
                FSP2.hasSpawned = false;
                FSP3.hasSpawned = false;
                FSP4.hasSpawned = false;
                UpdateTextAfter.checkbill = false;
                UpdateTextAfter2.checkbill = false;
                UpdateTextAfter3.checkbill = false;
                UpdateTextAfter4.checkbill = false;
                Datainfo.score = 0;
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
