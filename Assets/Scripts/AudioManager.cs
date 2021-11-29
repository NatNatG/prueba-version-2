using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instancia;

    public void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }

        else if (instancia != this)
        {
            Destroy(gameObject);
        }
    }

    //Lista de audios.
    public List<AudioClip> SFXList;

    public List<AudioSource> SFXAudioSources;

    public AudioSource musicAudioSource;

    public List<AudioClip> MusicList;


    public void PlaySFX(int clipNumber)
    {
        //Buscar un AudioSource que no este reproduciendo audio en este momento.
        foreach (AudioSource source in SFXAudioSources)
        {
            if (!source.isPlaying)
            {
                source.PlayOneShot(SFXList[clipNumber]);
                return;
            }
        }
                    
    }

    public void PlayMusic(int clipNumber, bool loop)
    {
        //¿Cuál queremos que se reproduzca?
        musicAudioSource.clip = MusicList[clipNumber];
        // Como queremos que se reproduzca.
        musicAudioSource.loop = loop;
        //Lo reproducimos.
        musicAudioSource.Play();
    }
}
