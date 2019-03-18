using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffekte : MonoBehaviour
{

    public AudioSource levelMusik;
    public AudioSource gameOverMusik;
    public AudioSource winMusik;
    public AudioSource pauseMusik;

    public bool levelSong = true;
    public bool gameOverSong = false;
    public bool winSong = false;
    public bool pauseSong = false;

    public void LevelMusik()
    {
        levelSong = true;
        gameOverSong = false;
        winSong = false;
        pauseSong = false;
        levelMusik.Play();
    }

    public void GameOverSound()
    {
        if (levelMusik.isPlaying)
        {
            levelMusik.Stop();
            levelSong = false;
        }

        if (!gameOverMusik.isPlaying && gameOverSong == false)
        {
            gameOverMusik.Play();
            gameOverSong = true;
        }
    }

    public void WinSound()
    {
        if (levelMusik.isPlaying)
        {
            levelMusik.Stop();
            levelSong = false;
        }

        if (!winMusik.isPlaying && winSong == false)
        {
            winMusik.Play();
            winSong = true;
        }
    }

   /* public void PauseSound()
    {
        if (Menuekontolle.istPause)
        {
            levelMusik.Stop();
            levelSong = false;

            pauseMusik.Play();
            pauseSong = true;
        }

    }*/
}
