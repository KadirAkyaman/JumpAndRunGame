using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    Animator animator;
    bool lookingRight = true;


    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        animator = GetComponent<Animator>();

    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.A) && lookingRight == true)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            lookingRight = false;
        }

        if (Input.GetKey(KeyCode.D) && lookingRight == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            lookingRight = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("movement", 1);
            animator.SetInteger("isPress", 1);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("movement", 1);
            animator.SetInteger("isPress", 1);

        }
        else
        {
            animator.SetInteger("movement", 0);
            animator.SetInteger("isPress", 0);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetInteger("isJump", 1);

        }
        else
        {
            animator.SetInteger("isJump", 0);
        }

    }

    
}
