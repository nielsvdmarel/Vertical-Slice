using UnityEngine;
using System.Collections;

public class CloudsMovement : MonoBehaviour {

    public int cloudMoveSpeed;
    private Vector3 Pos;
    public Vector3 StartPos = new Vector3(3, 3, 105);
    public Vector3 EndPos;
    
    

    void Start ()
    {
        Pos = EndPos;
        cloudMoveSpeed = Random.Range(1, 5);
    }

    

    void Update()
    {
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y,transform.position.z), Pos, cloudMoveSpeed * Time.deltaTime);
        if (transform.position == EndPos)
        {
           Pos = StartPos; 
        }

        if (transform.position == StartPos)
        {
            Pos = EndPos;
        }
    }







}



