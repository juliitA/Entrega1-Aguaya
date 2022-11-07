using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float damage;
    public Vector3 tamaño;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Duplicar();

        }
    }

    private void Duplicar()
    {
        transform.localScale = tamaño;
    }
}
