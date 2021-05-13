using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlime : MonoBehaviour
{
    private Rigidbody2D slime;
    public float targetTime = 3f;
    Vector2 move = Vector2.left;
    public GameObject respawn;
    public GameObject text;
    public GameObject temp;

    // Start is called before the first frame update
    void Start()
    {
        slime = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        slime.MovePosition(slime.position + move * Time.deltaTime);
        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        targetTime = 3f;
        move *= (-1);
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
