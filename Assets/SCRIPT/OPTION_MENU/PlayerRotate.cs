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
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            ChangeButtonColor(w1);
            if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))&& (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
            {
                ChangeButtonColor(d1);              
            }
            else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))&& (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
            {
                ChangeButtonColor(a1);
           
            }
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.Space))
            {
                animator.Play("W0");
                ChangeButtonColor(shift1);
            }
            else
            {
                animator.Play("W");
            }
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            
            ChangeButtonColor(a1);
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
            {
                ChangeButtonColor(w1);
                
            }
            else if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
            {
                ChangeButtonColor(s1);         
            }
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.Space))
            {
                animator.Play("A0");
                ChangeButtonColor(shift1);
            }
            else
            {
                animator.Play("A");
            }
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            ChangeButtonColor(s1);
            if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
            {
                ChangeButtonColor(a1);       
            }
            else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
            {
                ChangeButtonColor(d1);           
            }
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.Space))
            {
                animator.Play("S0");
                ChangeButtonColor(shift1);
            }
            else
            {
                animator.Play("S");
            }
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            ChangeButtonColor(d1);
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
            {
                ChangeButtonColor(s1);               
            }
            else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
            {
                ChangeButtonColor(w1);    
            }
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.Space))
            {
                animator.Play("D0");
                ChangeButtonColor(shift1);
            }
            else
            {
                animator.Play("D");
            }
        }
        else
        {
            animator.Play("Stand");
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

}
