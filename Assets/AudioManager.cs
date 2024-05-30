using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Source-----")]
    [SerializeField] AudioSource musicSource;

    [SerializeField] AudioSource SFXSource;

    [Header("-----Audio Clip----")]
    public AudioClip background;
    public AudioClip death;

    public AudioClip gameOver;

    public AudioClip flap;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void Stop()
    {
        musicSource.clip = background;
        musicSource.Stop();
    }
}
