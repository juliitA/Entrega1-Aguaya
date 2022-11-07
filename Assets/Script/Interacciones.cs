using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacciones : MonoBehaviour
{
    private int vida = 3;
    private int puntos = 0;
    Vector3 posInicial;
    private bool choque;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        vidaJug();
        if (choque == true)
        {
            Respawn();
            choque = false;
        }
    }
    void vidaJug()
    {
        if (vida == 0)
        {
            Debug.Log("Game Over");
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.transform.gameObject.tag == "Ghost")
        {
            choque = true;
            vida -= 1;
            Debug.Log("Perdiste una vida");

        }
    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.transform.gameObject.tag == "coin")
        {
            puntos ++;
            Destroy(col.transform.gameObject);
            Debug.Log("Ganaste un punto");
        }
    }
    void Respawn()
    {
        transform.position = posInicial;
    }
}
