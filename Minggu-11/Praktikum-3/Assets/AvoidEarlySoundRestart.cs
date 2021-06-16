using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvoidEarlySoundRestart : MonoBehaviour
{
    public AudioSource audioSource;
    public Text message;
    void Update()
    {
        string statusMessage = "Play sound";
        if (audioSource.isPlaying)
            statusMessage = "(sound playing)";
        message.text = statusMessage;
    }
    // button click handler
    public void PlaySoundIfNotPlaying()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
    }
}