using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Death : MonoBehaviour
{
    private Rigidbody2D rb;
    public float targetTime = 100f;
    public GameObject respawn;
    public GameObject text;
    public GameObject temp;
    public GameObject camera;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D another)
    {

        if (another.tag == "Player")
        {
            another.transform.position = respawn.transform.position;

            text.transform.position = temp.transform.position;

        }
    }
  
}
