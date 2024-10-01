using UnityEngine;
public class Background : MonoBehaviour
{
    public AudioSource backgroundMusicSource;
    public AudioClip backgroundMusic;
    private void Start()
    {
        if (backgroundMusicSource == null)
        {
            backgroundMusicSource = gameObject.AddComponent<AudioSource>();
        }
        if (backgroundMusic != null)
        {
            backgroundMusicSource.clip = backgroundMusic;
            backgroundMusicSource.loop = true; // เล่นซ้ำ
            backgroundMusicSource.Play();

        }
    }
    // เรียกใช้เมื่อกดปุ่ม Play
    public void OnPlayButtonPressed()
    {
        if (backgroundMusicSource.isPlaying)
        {
            backgroundMusicSource.Stop();
        }
    }
}