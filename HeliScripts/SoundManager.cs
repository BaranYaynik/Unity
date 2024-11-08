using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public static SoundManager instance;
    public AudioSource coinsource;
    public AudioClip coinsound;
    private void Awake()
    {
        instance = this; }


public void start()
{
        coinsource= GetComponent<AudioSource>();
}


    }

    
