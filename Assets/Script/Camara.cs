using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour

    
{
    public GameObject camJug;
    public GameObject camLug;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (camJug.activeInHierarchy)
            {
                camJug.SetActive(false);
                camLug.SetActive(true);
            }
            else
            {
                camJug.SetActive(true);
                camLug.SetActive(false);
            }
        }
    }
}
