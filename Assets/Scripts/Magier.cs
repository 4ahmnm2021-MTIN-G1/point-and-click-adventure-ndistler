using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magier : MonoBehaviour
{
    public int age;
    public bool magic;
    public float height;
    public string name;

    public Camera cam;

    public GameObject go;

    public BoxCollider bc;

    public Rigidbody rb;

    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        age = 5;
        magic = true;
        height = 5.3f;
        name = "hello";
        cam.farClipPlane = 50;

        go.name = "NeuerName";

        bc.isTrigger = true;

        rb.useGravity = false;

        rb.mass = 80;

        txt.fontSize = 23;
        txt.text = "Wilfried Gruber";




    }

    // Update is called once per frame
    void Update()
    {

    }
}
