using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicPlayStinger : MonoBehaviour
{

    private AudioSource myAudioSource;

    // Use this for initialization
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            Debug.Log("The collision was not from the player.  It was from: " + other.tag);
            return;
        }
        
        if (myAudioSource == null)
        {
            Debug.Log("MusicPlayStinger: There is no AudioSource attached to this game object.");
            return;
        }

        if (myAudioSource.clip == null)
        {
            Debug.Log("MusicPlayStinger: There is no Clip attached to this AudioSource.");
            return;
        }

        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Stop();
            myAudioSource.Play();
            Debug.Log("MusicPlayStinger: Playing the stinger.");
        }
        else
        {
            myAudioSource.Play();
        }
    }
}

