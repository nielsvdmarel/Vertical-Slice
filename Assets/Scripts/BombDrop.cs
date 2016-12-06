using UnityEngine;
using System.Collections;

public class BombDrop : MonoBehaviour
{
    public GameObject bomb;
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bomb, transform.position, transform.rotation);
            
        }
    }

   



}

