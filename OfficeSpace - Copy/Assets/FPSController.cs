using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public float movementDirection;
    public float playerSpeed = 2.25f;
    public float cameraSpeedX = 2f;
    public float cameraSpeedY = 2f;
    private float cameraY;
    private float cameraX;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotation();
    }

    void Movement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(cam.transform.forward.x, 0f, cam.transform.forward.z).normalized * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(cam.transform.forward.x, 0f, cam.transform.forward.z).normalized * playerSpeed * Time.deltaTime * -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(cam.transform.right.x, 0f, cam.transform.right.z).normalized * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(cam.transform.right.x, 0f, cam.transform.right.z).normalized * playerSpeed * Time.deltaTime * -1;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            playerSpeed += playerSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed -= playerSpeed/2;
        }
    }

    void Rotation()
    {
        cameraX += cameraSpeedX * Input.GetAxis("Mouse X");
        cameraY -= cameraSpeedY * Input.GetAxis("Mouse Y");
        cam.transform.eulerAngles = new Vector3(cameraY, cameraX, 0.0f);
    }
}
