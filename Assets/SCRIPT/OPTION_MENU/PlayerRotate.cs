using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerRotate : MonoBehaviour
{

    public Animator animator;
    public Button w1, a1, s1, d1, shift1,e1;

    private Color defaultColor;
    private Color pressedColor = Color.gray;

    private void Start()
    {
        defaultColor = w1.colors.normalColor;
    }

    private void Update()
    {
        ResetButtonColors();
        if (Input.GetKey(KeyCode.E))
        {
            ChangeButtonColor(e1);
        }
        if (Input.GetKey(KeyCode.W))
        {
            ChangeButtonColor(w1);
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                ChangeButtonColor(d1);
                transform.rotation = Quaternion.Euler(0,45,0);
                movement();
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                ChangeButtonColor(a1);
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
            ChangeButtonColor(a1);
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                ChangeButtonColor(w1);
                transform.rotation = Quaternion.Euler(0, -45, 0);
                movement();
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
            {
                ChangeButtonColor(s1);
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
            ChangeButtonColor(s1);
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                ChangeButtonColor(a1);
                transform.rotation = Quaternion.Euler(0, -135, 0);
                movement();
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                ChangeButtonColor(d1);
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
            ChangeButtonColor(d1);
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
            {
                ChangeButtonColor(s1);
                transform.rotation = Quaternion.Euler(0, 135, 0);
                movement();
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                ChangeButtonColor(w1);
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

    private void ChangeButtonColor(Button button)
    {
        ColorBlock colorBlock = button.colors;
        colorBlock.normalColor = pressedColor;
        button.colors = colorBlock;
    }

    private void ResetButtonColors()
    {
        ResetButtonColor(w1);
        ResetButtonColor(a1);
        ResetButtonColor(s1);
        ResetButtonColor(d1);
        ResetButtonColor(shift1);
        ResetButtonColor(e1);
    }

    private void ResetButtonColor(Button button)
    {
        ColorBlock colorBlock = button.colors;
        colorBlock.normalColor = defaultColor;
        button.colors = colorBlock;
    }

    private void movement()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            //transform.Translate(Vector3.forward * Time.deltaTime * (Datainfo.speedplayer + 10f));
            animator.Play("run");
            ChangeButtonColor(shift1);
        }
        else
        {
            //transform.Translate(Vector3.forward * Time.deltaTime * Datainfo.speedplayer);
            animator.Play("walk");
        }
    }

}
