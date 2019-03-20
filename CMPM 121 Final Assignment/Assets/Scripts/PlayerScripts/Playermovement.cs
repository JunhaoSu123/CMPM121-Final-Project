using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class Playermovement : MonoBehaviour
{
    PlayerMotor motor;
    float speed = 100;
    float rotationSpeed = 300;
    float gravity = 1000;
    float rotation = 0f;
    //public static int count;
    //public GameObject ChangeBack;
    Vector3 moveDir = Vector3.zero;
    //public GameObject partical_Effect;
    CharacterController controller;
    //Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        motor = GetComponent<PlayerMotor>();
        controller = GetComponent<CharacterController>();
        //anim = GetComponent<Animator>();
        //count = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                //anim.SetInteger("condition", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                //anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);
            }
        }

        rotation += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rotation, 0);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }

}

