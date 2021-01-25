using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementClick : MonoBehaviour
{
    public Transform thisTransform;
    public Transform cam;
    public Vector3 mousePos;
    public Vector3 worldPos;
    public Vector3 playerPos;
    public Vector3 camPos;
    public float speed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        playerPos = thisTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        thisTransform.position = Vector3.MoveTowards(thisTransform.position, playerPos, speed);
        //cam.position = Vector3.MoveTowards(cam.position, camPos, speed);
    }

    public void SetNewDestination()
    {
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        playerPos = new Vector3(worldPos.x, worldPos.y, thisTransform.position.z);
        //camPos = new Vector3(worldPos.x, worldPos.y, cam.position.z);
    }   

    public void Enter()
    {
        playerPos = new Vector3 (2, -4, 0);
    }
}
