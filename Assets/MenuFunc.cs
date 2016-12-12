using UnityEngine;
using System.Collections;

public class MenuFunc : MonoBehaviour {

    public GameObject MenuMouse;
    public bool Isclicked;
    private Vector2 MouseTarget;
    GameObject MouseClone;
    private Vector3 target;

    void Start ()
    {
        Isclicked = false;
        
       
    }
	
	
    

	void Update ()
    {
       

        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(target.x);
        //Debug.Log(target.y);


        target.z = 3;
        MouseTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        if(MouseClone != null)
        {
            MouseClone.transform.position = target;
            if(MouseClone.transform.position.x == 2)
            {
                
            }
            
        }
       

        if (Isclicked)
        {
            if (Input.GetMouseButtonDown(1))
            {
               
                Isclicked = false;
                Camera.main.GetComponent<CameraController2>().enabled = true;


                Destroy(MouseClone);

            }

        }
        else
        {
            if (Input.GetMouseButtonDown(1))
            {
                
                Isclicked = true;
                Camera.main.GetComponent<CameraController2>().enabled = false;
                //Instantiate(MenuMouse, new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity) as GameObject;

                MouseClone = Instantiate(MenuMouse, new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity) as GameObject;

            }
        }


    }

    void MenuMouseOut()
    {

    }
}
