using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAudio : MonoBehaviour
{
    private AudioSource AudioSource;
    [SerializeField]
    private AudioClip scream_Clip, die_Clip;
    [SerializeField]
    private AudioClip[] attack_Clips;
    // Start is called before the first frame update
    void Awake ()
    {
        AudioSource = GetComponent<AudioSource>();
    }
public void Play_ScreamSound()
    {
        AudioSource.clip = scream_Clip;
        AudioSource.Play();
    }
  public void Play_AttackSound()
    {
        AudioSource.clip = attack_Clips[Random.Range(0, attack_Clips.Length)];
        AudioSource.Play();

    }
    public void Play_DeadSound()
    {
        AudioSource.clip = die_Clip;
        AudioSource.Play();
    }
}
