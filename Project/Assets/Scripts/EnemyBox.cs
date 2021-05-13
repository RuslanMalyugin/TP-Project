using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : MonoBehaviour
{
    public GameObject respawn;
    public GameObject text;
    public GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
