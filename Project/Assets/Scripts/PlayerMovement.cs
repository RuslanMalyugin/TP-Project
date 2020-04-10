using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public float targetTime = 3.0f;
    bool chk = false;
    bool chk2 = false;
    public GameObject text;
    public GameObject temp;



    // Update is called once per frame
    void Update()
    {

        if (text.transform.position != temp.transform.position)
            chk2 = true;
        if (chk2)
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
    

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            crouch = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            crouch = false;
        }

    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    void timerEnded()
    {
        text.transform.position = temp.transform.position;
        chk2 = false;
        targetTime = 3.0f;
    }
}