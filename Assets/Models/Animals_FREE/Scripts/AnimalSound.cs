using UnityEngine;
using Vuforia;

public class AnimalSound : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject imageTarget;

    public void PlaySound()
    {
        if (imageTarget.activeInHierarchy && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}