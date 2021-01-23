using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnTetro : MonoBehaviour {

    //Attributes -
    public int proxPeca;
    public Transform[] criaPecas;
    public List<GameObject> mostraPecas;

    // Initialization -
	void Start ()
    {
        proxPeca = Random.Range(0, 7);
        proximaPeca();
    }

    public void proximaPeca()
    {
        Instantiate(criaPecas[proxPeca], transform.position, Quaternion.identity);
        proxPeca = Random.Range(0, 7);
        for (int i = 0; i < mostraPecas.Count; i++)
        {
            mostraPecas[i].SetActive(false);
        }

        mostraPecas[proxPeca].SetActive(true);
    } // <-- Método que spawna e mostra a próxima peça.
}
