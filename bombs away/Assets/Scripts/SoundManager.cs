using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    public AudioClip coinCollectSound;

    public AudioClip winSound;

    public AudioClip hazardHitSound;

    public void Awake()
    {
        //wont stop upon player respawn, but will destory when new scene is loaded 
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayCoinCollectSound()
    {
        audioSource.clip = coinCollectSound;
        audioSource.Play();
    }

    public void PlayWinSound()
    {
        audioSource.clip = winSound;
        audioSource.Play();
    }

    public void PlayHazardHitSound()
    {
        audioSource.clip = hazardHitSound;
        audioSource.Play();
    }
}
