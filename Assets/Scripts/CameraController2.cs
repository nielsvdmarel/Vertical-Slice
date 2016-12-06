using UnityEngine;
using System.Collections;

public class CameraController2 : MonoBehaviour {

    public float beginPosX;
    public float beginPosY;
    public float cameraSpeed;
    public float speed = 1.5f;
    public float testttt;
    private Vector2 target;

    void Start()
    {
        Cursor.visible = false;
        Camera.main.transform.position = new Vector3(0, 0, 0);
        


    }

    // Update is called once per frame
    void Update()
    {
          Vector3 mouse = Input.mousePosition;
          mouse = mouse * cameraSpeed;
          transform.position = Camera.main.ScreenToViewportPoint(mouse);

      
        

        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(target.x);

    }

    private void MoveCursor()
    {
        // Set the Current cursor, move the cursor's Position,
        // and set its clipping rectangle to the form. 

        
    }
}