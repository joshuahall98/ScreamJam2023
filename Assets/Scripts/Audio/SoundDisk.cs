using AudioSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDisk : MonoBehaviour
{
    [SerializeField] AudioScriptableObject[] sounds;

    private void Awake()
    {
        this.GetComponentInParent<AudioManager>().GenerateAudioComponentList(sounds);
    }
}