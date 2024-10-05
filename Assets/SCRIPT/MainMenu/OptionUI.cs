using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionUI : MonoBehaviour
{
    [SerializeField] private Button backButton;
    //[SerializeField] private Slider soundEffectsSlider;
    //[SerializeField] private Slider musicSlider;

    private void Awake()
    {
        backButton.onClick.AddListener(() => {
            SceneManager.LoadScene(Loader.Scene.StartMenu.ToString());
        });

    }

    //private void SetSoundEffectsVolume(float volume)
    //{
    //    // ปรับระดับเสียง Sound Effects
    //    AudioManager.Instance.SetSoundEffectsVolume(volume);
    //    PlayerPrefs.SetFloat("SoundEffectsVolume", volume);
    //}

    //private void SetMusicVolume(float volume)
    //{
    //    // ปรับระดับเสียงเพลง
    //    AudioManager.Instance.SetMusicVolume(volume);
    //    PlayerPrefs.SetFloat("MusicVolume", volume);
    //}

    //private void ShowTutorial()
    //{
    //    // แสดงหน้าต่างคำแนะนำการเล่น
    //    tutorialPanel.SetActive(true);
    //}

    //public void CloseTutorial()
    //{
    //    // ซ่อนหน้าต่างคำแนะนำการเล่น
    //    tutorialPanel.SetActive(false);
    //}
}

