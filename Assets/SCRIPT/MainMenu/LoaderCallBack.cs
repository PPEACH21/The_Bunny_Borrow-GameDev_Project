using UnityEngine.SceneManagement;
using UnityEngine;

public class LoaderCallBack : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == Loader.Scene.LoadingScene.ToString())
        {
            Loader.LoaderComeback();
        }
    }
}
