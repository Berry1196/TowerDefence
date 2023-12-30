using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            // Create an AudioSource component on the AudioManager GameObject
            s.source = gameObject.AddComponent<AudioSource>();
            // Set the AudioClip of the AudioSource component to the clip in the current Sound
            s.source.clip = s.clip;
            // Set the volume of the AudioSource component to the volume in the current Sound
            s.source.volume = s.volume;
            // Set the pitch of the AudioSource component to the pitch in the current Sound
            s.source.pitch = s.pitch;
            // Set the loop of the AudioSource component to the loop in the current Sound
            s.source.loop = s.loop;
        }

    }


    public void Play(string name)
    {
        // Find the Sound in the sounds array that has the name passed in as a parameter
        Sound s = System.Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            // If the Sound cannot be found, print a warning message and return
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        // Play the AudioClip of the Sound we found
        s.source.Play();
    }

    public void Stop(string name)
    {
        // Find the Sound in the sounds array that has the name passed in as a parameter
        Sound s = System.Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            // If the Sound cannot be found, print a warning message and return
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        // Stop the AudioClip of the Sound we found
        s.source.Stop();
    }
}
