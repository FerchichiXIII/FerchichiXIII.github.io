using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float Speed = 2f;
    public Transform Player;
    public Camera Cam;
    public Vector3 turn;
    public float newFOV = 30f;
    public float normalFOV = 60f;

    void Start()
    {
        turn = transform.position - Player.position;
    }

    // Update is called once per frame
    void Update()
    {
        turn = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * Speed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * Speed, Vector3.left) * turn;
        transform.position = Player.position + turn;
        transform.LookAt(Player.position);
        if (Input.GetMouseButtonDown(1))
        {
            Cam.fieldOfView = newFOV;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            Cam.fieldOfView = normalFOV;
        }
    }
 }
 