using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private float _startSpeed;
    private float _pushSpeed;
    public Vector2 velocity;
    private bool _grounded;

    private Rigidbody2D rb2d;

	
	void Start ()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	
	void Update ()
    {

        if (Input.GetKey("left"))
        {
            
                transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            
        }

        if (Input.GetKey("right"))
        {

            transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);

        }

    }

    void FixedUpdate()
    {


        if (Input.GetKey("left"))
            rb2d.MovePosition(rb2d.position - velocity * Time.fixedDeltaTime);
       

        if (Input.GetKey("right"))
            rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
        
    }
    

    }

