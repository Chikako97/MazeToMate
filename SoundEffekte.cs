using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffekte : MonoBehaviour
{

    public AudioSource levelMusik;
    public AudioSource gameOverMusik;
    public AudioSource winMusik;

    public bool levelSong = true;
    public bool gameOverSong = false;
    public bool winSong = false;

    public void LevelMusik()
    {
        levelSong = true;
        gameOverSong = false;
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
}
