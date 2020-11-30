using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public float massctrl;
    public int oil;
    public bool loop;
    public string name;

    public Joint hingejoint;
    public AudioSource audiosource;
    public SpriteRenderer spriterenderer;
    public GameObject gameobject;
    


    // Start is called before the first frame update
    void Start()
    {
        hingejoint.massScale = massctrl;
        spriterenderer.sortingOrder = oil;
        gameobject.name = name;
        audiosource.loop = loop;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
