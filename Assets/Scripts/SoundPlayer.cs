using System;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public static SoundPlayer Instance { get; set; }

    public Transform player;

    public AudioSource wavesSound;

    private bool isPlaying;

    void Update()
    {
        bool isInRange =  Math.Abs(player.position.x) <= 50f && Math.Abs(player.position.z) <= 50f;
        
        if (isInRange && !isPlaying)
        {
            wavesSound.Play();
            isPlaying = true;
        }
        else if (!isInRange && isPlaying)
        {
            wavesSound.Stop();
            isPlaying = false;
        }
    }
}
