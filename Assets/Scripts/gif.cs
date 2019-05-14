using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gif : MonoBehaviour
{
    //Atributos das imagens animadas -
    public Texture2D[] frames;
    public short fps = 10;
    public bool pause = false;

    //Atualização das imagens animadas -
    void Update()
    {
        int index = (short)(Time.time * fps) % frames.Length;
        GetComponent<RawImage>().texture = frames[index];
        if (Input.GetKeyDown(KeyCode.P))
        {
            pausa();
        }
    }

    public void pausa()
    {
        if (pause)
        {
            fps = 10;
            pause = false;
        }
        else
        {
            fps = 0;
            pause = true;
        }
    }
}
