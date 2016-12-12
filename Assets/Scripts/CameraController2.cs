using UnityEngine;
using System.Collections;

public class CameraController2 : MonoBehaviour {

    public float beginPosX;
    public float beginPosY;
    public float cameraSpeed;
    public float speed = 1.5f;
    public float testttt;
    private Vector2 target;
    private Vector3 oldPosition, offset;

    void Start()
    {
        Cursor.visible = false;
        //Camera.main.transform.position = new Vector3(beginPosX, beginPosY, 0);
        


    }

    // Update is called once per frame
    void Update()
    {
          Vector3 mouse = Input.mousePosition;
          mouse = mouse * cameraSpeed;
          transform.position = Camera.main.ScreenToViewportPoint(mouse) - offset;

      
        

        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(target.x);
       // Debug.Log(target.y);
    }

    

    void OnEnable()
    {

        Vector3 mouse = Input.mousePosition;
        mouse = mouse * cameraSpeed;
        offset = Camera.main.ScreenToViewportPoint(mouse) - oldPosition;
        //Debug.Log(transform.position);
    }

    void OnDisable()
    {
        oldPosition = transform.position;
        //Debug.Log(oldPosition);
    }
}