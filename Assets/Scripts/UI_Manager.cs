using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    //======System======\\
    public InteractableObject activeIO;
    public Text dialogFenster;
    public string identifierIO;
    
    //======Doors======\\
    public GameObject doorClosedRoom;
    public GameObject doorClosedBath;

    //======MoveArea======\\
    public GameObject moveAreaGO;

    //=======Counter Related=======\\
    public GameObject win;
    public GameObject plusOne;
    public Text counter;
    public int countadd = 0;

    //=======ClickedBools=======\\
    bool tvClicked;
    bool bedClicked;
    bool jewelryClicked;
    bool jewelry2Clicked;

    //=======Sounds=======\\
    public GameObject winSound;
    public GameObject talkSound;
    public GameObject questionSound;
    public GameObject nonSound;
    public GameObject plusOneSound;
    
    // COMMAND MENU LINE //
    public void DisplayText()
    {
        nonSound.SetActive(false);
        if (identifierIO != null){

            if (identifierIO == "Fernseher" && tvClicked == false){
                countadd ++;
                dialogFenster.text = "Ich habe einen Fingerabdruck gefunden!";
                tvClicked = true;
                plusOne.SetActive(true);

                plusOneSound.SetActive(true);
            }
            else if (identifierIO == "Bed" && bedClicked == false){
                countadd ++;
                dialogFenster.text = "Ich habe einen Fingerabdruck gefunden!";
                bedClicked = true;
                plusOne.SetActive(true);

                plusOneSound.SetActive(true);
            }
            else if (identifierIO == "JewelryBox" && jewelryClicked == false){
                countadd ++;
                dialogFenster.text = "Ich habe einen Fingerabdruck gefunden!";
                jewelryClicked = true;
                plusOne.SetActive(true);

                plusOneSound.SetActive(true);
            }
            else if (identifierIO == "JewelryBoxTwo" && jewelry2Clicked == false){
                countadd ++;
                dialogFenster.text = "Ich habe einen Fingerabdruck gefunden!";
                jewelry2Clicked = true;
                plusOne.SetActive(true);

                plusOneSound.SetActive(true);
            }

            else if (tvClicked == true || bedClicked == true || jewelryClicked == true || jewelry2Clicked == true){
                dialogFenster.text = "Hier habe ich bereits gesucht.";
                
                nonSound.SetActive(true);
            }


            if (identifierIO == "Schrank" || identifierIO == "miniSchrank" || identifierIO == "dünnerSchrank" || identifierIO == "Couch"){
                dialogFenster.text = "Hier hab ich nichts gefunden.";
                
                nonSound.SetActive(true);
            }
        }

        
        counter.text = countadd + "/4";

        if (countadd == 4)
        {
            win.SetActive(true);
            winSound.SetActive(true);

            plusOneSound.SetActive(false);
            plusOne.SetActive(false);
        }
    }

    public void Exit()
    {
        dialogFenster.text = ""; 
        plusOne.SetActive(false);

        //SOUNDS OFF
        plusOneSound.SetActive(false);
        nonSound.SetActive(false);
        winSound.SetActive(false);
        questionSound.SetActive(false);
    }


    // DOOR MENU LINE //
    public void Open()
    {
        Debug.Log("Use Funktion ist aufgerufen");
            if (identifierIO != null){
                if (identifierIO == "DoorRoom"){
                    doorClosedRoom.SetActive(false);
                    dialogFenster.text = "Mal schauen, was nach dieser Tür zu finden ist.";
                }

                if (identifierIO == "DoorBath"){
                    doorClosedBath.SetActive(false);
                    dialogFenster.text = "Mal schauen, was nach dieser Tür zu finden ist.";

                    moveAreaGO.SetActive(true);
                }
            }
    }

    

    public void Close()
    {
        if (identifierIO != null){
                if (identifierIO == "DoorRoom"){
                    doorClosedRoom.SetActive(true);
                    dialogFenster.text = "Jetzt ist sie zu.";
                }

                if (identifierIO == "DoorBath"){
                    doorClosedBath.SetActive(true);
                    dialogFenster.text = "Jetzt ist sie zu.";

                    moveAreaGO.SetActive(false);
                }
            }
    }
}
