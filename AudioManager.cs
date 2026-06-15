using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //再设置个单例

    public List<AudioType> audioTypes = new List<AudioType>(); 
    private Dictionary<string,AudioSource> dictionary = new Dictionary<string,AudioSource>();
    private void Awake()
    {
        foreach (AudioType audioType in audioTypes)
        {
            audioType.Source = this.gameObject.AddComponent<AudioSource>();

            audioType.Source.clip = audioType.Clip;
            audioType.Source.name = audioType.Name;
            audioType.Source.volume = audioType.Volume;
            audioType.Source.pitch = audioType.Pitch;
            audioType.Source.loop = audioType.IsLoop;

            dictionary.Add(audioType.Source.name, audioType.Source);
        }
    }
    public void Play(string name)
    {
        if (dictionary.TryGetValue(name, out AudioSource audioSource))
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning($"名称为{name}的音频不存在");
        }
    }
    public void Stop(string name)
    {
        if (dictionary.TryGetValue(name, out AudioSource audioSource))
        {
            audioSource.Stop();
        }
        else
        {
            Debug.LogWarning($"名称为{name}的音频不存在");
        }
    }
}
