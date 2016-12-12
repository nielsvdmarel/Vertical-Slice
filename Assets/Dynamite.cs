using UnityEngine;
using System.Collections;

public class Dynamite : MonoBehaviour {
   
    public bool MenuClicked;
	void Start ()
    {

        MenuClicked = false;
	}
	
	
	void Update ()
    {
        

        

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MenuClicked = true;
            
            
        }
    }

}

