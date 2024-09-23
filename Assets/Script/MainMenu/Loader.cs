using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene
    {
        MainMenu,
        GamePlay,
        LoadingScene,
        OptionUI
    }

    private static Scene targetScene;

    public static void Load(Scene targetScene)
    {
        Loader.targetScene = targetScene;
        SceneManager.LoadScene(Scene.LoadingScene.ToString());
    }

    public static void LoaderComeback()
    {
        GameObject loaderObject = new GameObject("Loader");
        loaderObject.AddComponent<LoaderCallback>().StartLoad();

    }


    private class LoaderCallback : MonoBehaviour
    {
        private bool isFirstUpdate = true;

        public void StartLoad()
        {
            StartCoroutine(LoadSceneWithDelay());
        }

        private IEnumerator LoadSceneWithDelay()
        {
            yield return new WaitForSeconds(0.8f);
            SceneManager.LoadScene(targetScene.ToString());
        }
    }



}