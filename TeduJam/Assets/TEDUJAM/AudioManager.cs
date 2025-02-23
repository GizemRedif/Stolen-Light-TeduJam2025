using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;
    public AudioClip backGround;
    public AudioClip spike;
    public AudioClip openDoor;
    public AudioClip closeDoor;
    public AudioClip walk;


    private void Start()
    {
        musicSource.clip = backGround;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        if (!sfxSource.isPlaying) // Eðer zaten çalmýyorsa oynat
        {
            sfxSource.PlayOneShot(clip);
        }
    }
    public void StopSFX()
    {
        sfxSource.Stop();
    }
}
