using UnityEngine;
using System.Collections;

public class MenuAnim : MonoBehaviour
{

    public Animator anim;
    public bool Isclicked;

    void Start()
    {
        anim = GetComponent<Animator>();

        Isclicked = false;
        anim.SetBool("MenuOut", false);
        anim.SetBool("MenuIn", false);


    }


    void Update()
    {
        if (Isclicked)
        {
            if (Input.GetMouseButtonDown(1))
            {
                anim.SetBool("MenuOut", true);
                anim.SetBool("MenuIn", false);
                Isclicked = false;
                Debug.Log("menu out");
            }

        }
        else
        {
            if (Input.GetMouseButtonDown(1))
            {
                Isclicked = true;
                anim.SetBool("MenuOut", false);
                anim.SetBool("MenuIn", true);
                Isclicked = true;
                Debug.Log("menu in");
            }
        }

       
        if(GameObject.Find("Dynamite").GetComponent<Dynamite>().MenuClicked == true)
            {
                Isclicked = true;
                Debug.Log("kut ani");
                anim.SetBool("MenuOut", true);
                anim.SetBool("MenuIn", false);
                Isclicked = true;
                Debug.Log("menu in");

        }


        }
    }

