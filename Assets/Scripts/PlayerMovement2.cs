using UnityEngine;
using System.Collections;

public class PlayerMovement2 : MonoBehaviour
{


    public float jumpHeight;
    public float moveSpeed;
    public bool grounded;
    public LayerMask isGround;
    private Collider2D myCollider;
    public float verticalJumpHeigt;
    public bool facingleft;
   


    void Start()
    {
        myCollider = GetComponent<CircleCollider2D>();
        facingleft = false;
    }

    
    void Update()
    {


        grounded = Physics2D.IsTouchingLayers(myCollider, isGround);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.y, verticalJumpHeigt);
               

                //GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpHeight * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);
            facingleft = false;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            facingleft = true;
        }

        if (facingleft == true)
        {
           // verticalJumpHeigt = -verticalJumpHeigt;
        }
        else
        {
          //  verticalJumpHeigt = verticalJumpHeigt;
        }


    }

}