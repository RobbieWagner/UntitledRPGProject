using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCard : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Mouse Over", false);
    }


    void OnMouseOver()
    {
        animator.SetBool("Mouse Over", true);
    }

    void OnMouseExit()
    {
        animator.SetBool("Mouse Over", false);
    }
}
