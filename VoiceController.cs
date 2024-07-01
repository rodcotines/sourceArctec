using UnityEngine;

public class VoiceSwitcher : MonoBehaviour
{
    // Reference to the AudioSource component
    public AudioSource audioSource;

    // Audio clips for male and female voices
    public AudioClip femaleVoiceClip;
    public AudioClip maleVoiceClip;

    // Track the current voice gender
    private bool isFemaleVoice = true;

    void Start()
    {
        // Ensure the audio source is set
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        // Set the initial voice to female
        audioSource.clip = femaleVoiceClip;
    }

    // Method to switch the voice
    public void SwitchVoice()
    {
        isFemaleVoice = !isFemaleVoice;

        if (isFemaleVoice)
        {
            audioSource.clip = femaleVoiceClip;
        }
        else
        {
            audioSource.clip = maleVoiceClip;
        }
    }

    // Method to play the current voice clip
    public void PlayVoice()
    {
        if (audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}
