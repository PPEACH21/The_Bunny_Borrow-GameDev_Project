using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject winPanel;
    float resettime;
    public static bool check = false;
    public static bool checkRE = false;

    void Start()
    {
        //เรียกฟังก์ชัน ShowWinPanel หลังจากเวลาผ่านไป 10 วินาที
        Invoke("ShowWinPanel", Datainfo.timeRemaining);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Home()
    {
        Datainfo.GoScene = 2;
        Time.timeScale = 1;
        check = false;
        checkRE = true;
        Datainfo.timeRemaining = Datainfo.timeDafault;
        SceneManager.LoadScene("LoadingScene");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        ResetAll();
        Time.timeScale = 1;
        check = false;
        checkRE = true;
    }


    public void ResetAll()
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

    public void ShowWinPanel()
    {   
        winPanel.SetActive(true); // แสดง winPanel
        Time.timeScale = 0; // หยุดเกมเมื่อจบ (ถ้าต้องการ)
        Datainfo.timeRemaining = Datainfo.timeDafault;
        check = true;
    }
}
