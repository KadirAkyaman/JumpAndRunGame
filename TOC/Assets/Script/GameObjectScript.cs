using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour
{
    Rigidbody rbd;
    [SerializeField] float jumpForce;
   [SerializeField] int speed;
    bool canJump;
    void Start()
    {
        
        rbd = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float charPosition = Mathf.Clamp(transform.position.z, -3.96f, 3.83f);
        transform.position = new Vector3(transform.position.x, transform.position.y, charPosition);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            rbd.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag=="ground")
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            canJump = false;
        }
    }


}
