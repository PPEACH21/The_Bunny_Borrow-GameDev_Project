using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button optionButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.GamePlay);
        });

        optionButton.onClick.AddListener(() => {
            SceneManager.LoadScene(Loader.Scene.OptionUI.ToString());
        });

        quitButton.onClick.AddListener(() => {
            Application.Quit();
        });
    }
}