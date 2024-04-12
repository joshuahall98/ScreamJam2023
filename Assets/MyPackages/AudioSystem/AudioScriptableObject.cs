using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "Audio", menuName = "ScriptableObject/Audio")]
public class AudioScriptableObject : ScriptableObject
{

    [Serializable]
    public class AudioList<T> : ObjectPool<T>
    {
        [Range(0f, 1f)]
        public float volume = 1;
        [Range(.1f, 3f)]
        public float pitch = 1;
    }

    public List<AudioList<AudioClip>> audioClips;

    public AudioMixerGroup audioMixerGroup;

    [Header ("Basic Controls")]
    [Range(-1f, 1f)]
    public float pan = 0;
    [Range(1, 10)]
    public int audioPriority = 5;
    public bool loop = false;
    public bool playWhilePaused = false;

    [Header ("Fade Controls")]
    public bool fadeIn = false;
    public float fadeInDuration = 1;
    public bool fadeOut = false;
    public float fadeOutDuration = 1;

    [Range(0f, 1f) , Header ("3D Controls")]
    public float spatialBlend = 0;
    [Range(0f, 5f)]
    public float dopplerLevel = 0;
    public AudioRolloffMode rolloffMode = AudioRolloffMode.Linear;
    public float minDistance = 1;
    public float maxDistance = 30;

    [HideInInspector]
    public AudioSource source;
}
