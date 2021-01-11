using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject commandMenu;
    public UI_Manager uiManager;
    public Text dialogFenster;
    public string inspectText;
    public SpriteRenderer sr;
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        commandMenu.active=false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDown()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, 0);
        commandMenu.active = true;
        commandMenu.transform.position  = newPosition ;

        uiManager.activeIO = this; //this = eigenes Objekt

    }

    public void OnMouseExit()
    {
        commandMenu.active = false;
    }
}

