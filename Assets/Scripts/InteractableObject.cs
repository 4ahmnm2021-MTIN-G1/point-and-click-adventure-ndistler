using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject commandMenu;
    public GameObject doorMenu;
    public GameObject uiManagerGO;

    public Text objectName;

    public UI_Manager uiManager;

    public Text dialogFenster;
    public string inspectText;
    [SerializeField] string identifier;

    // Start is called before the first frame update
    void Start()
    {
        commandMenu.active=false;
        doorMenu.active=false;
    }

    public void OnMouseDown()
    {
        uiManagerGO.GetComponent <UI_Manager>().identifierIO = identifier;
        uiManager.activeIO = this; //this = eigenes Objekt
        
       
        if (identifier != "DoorRoom" && identifier != "DoorBath"){
            commandMenu.active = true;
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, 0);
            commandMenu.transform.position  = newPosition ;
            dialogFenster.text = inspectText;

            //QUESTION SOUND
            uiManagerGO.GetComponent <UI_Manager>().questionSound.active = true;
        }
    
        else{
            Debug.Log("door erkannt");

            doorMenu.active = true;

            Vector3 newdoorPosition = new Vector3(transform.position.x, transform.position.y, 0);
            doorMenu.transform.position  = newdoorPosition ;
        }
        

        
    }

    public void OnMouseExit()
    {
        uiManagerGO.GetComponent <UI_Manager>().identifierIO = null;
        uiManagerGO.GetComponent <UI_Manager>().plusOne.active = false;
        commandMenu.active = false;
        doorMenu.active = false;
        dialogFenster.text = "";
        objectName.text = "";

        //SOUNDSOFF
        uiManagerGO.GetComponent <UI_Manager>().questionSound.active = false;
        uiManagerGO.GetComponent <UI_Manager>().winSound.active = false;
        uiManagerGO.GetComponent <UI_Manager>().talkSound.active = false;
        uiManagerGO.GetComponent <UI_Manager>().plusOneSound.active = false;
        uiManagerGO.GetComponent <UI_Manager>().nonSound.active = false;
    }

    public void OnMouseOver()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, 0);
        objectName.transform.position = newPosition ;
        objectName.text = gameObject.name;

        if (commandMenu.active == true || doorMenu.active == true)
        {
            objectName.text = "";
        }
    }
}

