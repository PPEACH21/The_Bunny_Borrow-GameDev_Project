using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{

    public Animator animator;


    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0,45,0);
                movement();
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0,-45,0);
                movement();
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                movement();
            }

        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                transform.rotation = Quaternion.Euler(0, -45, 0);
                movement();
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
            {
                transform.rotation = Quaternion.Euler(0, -135, 0);
                movement();
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
                movement();
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0, -135, 0);
                movement();
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0, 135, 0);
                movement();
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, -180, 0);
                movement();
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
            {
                transform.rotation = Quaternion.Euler(0, 135, 0);
                movement();
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                transform.rotation = Quaternion.Euler(0, 45, 0);
                movement();
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                movement();
            }
        }
        else
        {
            animator.Play("waiting action");
        }

    }

    private void run()
    {
        
    }

    private void movement()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * (Datainfo.speedplayer + 10f));
            animator.Play("run");
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Datainfo.speedplayer);
            animator.Play("walk");
        }
    }

}
