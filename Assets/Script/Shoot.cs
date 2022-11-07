using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float destroyTime; 

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
    }
}
