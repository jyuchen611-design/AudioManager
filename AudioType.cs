using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[Serializable]
public class AudioType
{ 
    public AudioClip Clip;
    public AudioSource Source;
    public AudioMixerGroup Group;

    public string Name;
    public float Volume;
    public float Pitch;
    public bool IsLoop;
}
