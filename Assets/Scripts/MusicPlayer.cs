using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    // Atributos -
    public AudioClip[] clips;
    private AudioSource mpSource;
    public bool pause = false;

    // Inicialização -
    void Start ()
    {
        mpSource = FindObjectOfType<AudioSource>();
	}

    // Atualização -
	void Update ()
    {
		if (!mpSource.isPlaying)
        {
            mpSource.clip = GetRandomClip();
            if (pause == true)
            {
                mpSource.Pause();
            }
            else
            {
                mpSource.Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            pausa();
        }
    }

    // Métodos -
    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    } // <-- Método que executa uma música randômica.

    public void pausa()
    {
        if (pause)
        {
            pause = false;

        }
        else
        {
            pause = true;
            mpSource.Pause();
        }
    }
}