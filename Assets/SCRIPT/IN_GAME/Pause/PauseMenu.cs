using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject winPanel;

    void Start()
    {
        // เรียกฟังก์ชัน ShowWinPanel หลังจากเวลาผ่านไป 10 วินาที
        //Invoke("ShowWinPanel", 5f);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Home()
    {
        SceneManager.LoadScene("LoadingScene");
        Datainfo.GoScene = 2;
        Time.timeScale = 1;
        AudioManager.instance.musicSource.Pause();
       
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    
    void ShowWinPanel()
    {
        winPanel.SetActive(true); // แสดง winPanel
        Time.timeScale = 0; // หยุดเกมเมื่อจบ (ถ้าต้องการ)
    }
}
