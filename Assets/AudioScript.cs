using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip themeSong;
    public AudioClip score;
    public AudioClip hit;
    public AudioClip flap;

    // Start is called before the first frame update
    [ContextMenu("Play Theme")]
    public void playTheme()
    {
        audioSource.loop = true;
        audioSource.Play();
    }
    [ContextMenu("Play Score Sound")]
    public void playEffect(string effect)
    {
        audioSource.loop = false;
        if (effect.Equals("score"))
        {
            audioSource.PlayOneShot(score);
        }
        if (effect.Equals("hit"))
        {
            audioSource.PlayOneShot(hit);
        }
        if (effect.Equals("flap"))
        {
            audioSource.PlayOneShot(flap);
        }
        audioSource.loop = true;
    }
}
