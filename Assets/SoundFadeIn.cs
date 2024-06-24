using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFadeIn : MonoBehaviour
{
    public AudioSource audioSource;
    public float fadeInDuration = 2f; // Duration for the fade-in

    private float startVolume = 0f;
    private float timer = 0f;
    private bool fadeInComplete = false;

    void Start()
    {
        startVolume = audioSource.volume;
        audioSource.volume = 0f; // Set initial volume to 0
        audioSource.Play(); // Start playing the background music

        StartCoroutine(FadeInMusic());
    }

    IEnumerator FadeInMusic()
    {
        float fadeInRate = startVolume / fadeInDuration;
        float fadeInProgress = 0.0f;

        while (fadeInProgress < 1.0f)
        {
            audioSource.volume = Mathf.Lerp(0, startVolume, fadeInProgress);
            fadeInProgress += fadeInRate * Time.deltaTime;

            yield return null;
        }

        audioSource.volume = startVolume;
        fadeInComplete = true; // Flag to indicate fade-in is complete
    }

    void Update()
    {
        // If the fade-in is complete, you can continue playing the music normally
        if (fadeInComplete)
        {
            // Add any additional logic here if needed
        }
    }
}
