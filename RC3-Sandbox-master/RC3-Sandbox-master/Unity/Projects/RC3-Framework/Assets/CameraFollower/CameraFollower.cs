using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {
    public float CameraMoveSpeed = 60.0f;
    public GameObject CameraFollowObj;
    Vector3 FollowPos;
    public float clampAngle = 100.0f;
    public float inputSensitivity = 30.0f;
    public GameObject CameraObj;
    public GameObject PlayerObj;
    public float camDistanceXToplayer;
    public float camDistanceYToplayer;
    public float camDistanceZToplayer;
    public float mouseX;
    public float mouseY;
    public float finalInputX;
    public float finalInputZ;
    public float smoothX;
    public float smoothY;
    private float rotY = 0.0f;
    private float rotX = 0.0f;
   // private float rotZ= 0.0f;
    public Transform target;

	// Use this for initialization
	void Start ()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Forward();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Right();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Left();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Back();
        }
        //set up rotation of the sticks here
        //float inputX = Input.GetAxis("RightStickHorizontal");
        //float inputZ = Input.GetAxis("RightStickVertical");
        //mouseX = Input.GetAxis("Mouse X");
        //mouseY = Input.GetAxis("Mouse Y");
        //finalInputX = inputX + mouseX;
        //finalInputZ = inputZ + mouseY;

        //rotY += finalInputX * inputSensitivity * Time.deltaTime;
        //rotX += finalInputZ * inputSensitivity * Time.deltaTime;

        //rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        // var r = target.localRotation;
        //rotX = r.x;
        //rotY = r.y;

        //Quaternion localRotation = Quaternion.Euler(rotX, rotY-90, 0.0f);
        //transform.rotation = localRotation;

    }

    private void Forward()
    {
        Quaternion localRotation = Quaternion.Euler(0, 90, 0.0f);
        transform.rotation = localRotation;
    }
    private void Right()
    {
        Quaternion localRotation = Quaternion.Euler(0, 180, 0.0f);
        transform.rotation = localRotation;
    }
    private void Left()
    {
        Quaternion localRotation = Quaternion.Euler(0, 0, 0.0f);
        transform.rotation = localRotation;
    }
    private void Back()
    {
        Quaternion localRotation = Quaternion.Euler(0, 270, 0.0f);
        transform.rotation = localRotation;
    }
   

    private void LateUpdate()
    {
        CameraUpdater();
    }

    void CameraUpdater()
    {
        //set the target object to follow
        Transform target = CameraFollowObj.transform;

        //Move towards the game object that is th target
        float step = CameraMoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
