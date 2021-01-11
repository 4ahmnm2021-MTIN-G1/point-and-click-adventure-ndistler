using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    public Vector3 cameraPos;
    public Transform thisTransform;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cameraPos = 
        thisTransform.position = player.transform.position;
    }
}
