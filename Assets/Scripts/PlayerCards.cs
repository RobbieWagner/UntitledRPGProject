using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCards : MonoBehaviour
{

    public Animator animator;
    private bool mouseOver;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Mouse Over", false);
        mouseOver = false;
    }


    void OnMouseOver()
    {
        animator.SetBool("Mouse Over", true);
        mouseOver = true;
    }

    void OnMouseExit()
    {
        animator.SetBool("Mouse Over", false);
        mouseOver = false;
    }

    void Update()
    {
        if(mouseOver && Input.GetMouseButtonDown(0) && ((gameObject.transform.Find("BlankCard")) == null))
        {
            SceneManager.LoadScene("CharacterCreator");
        }
    }
}
