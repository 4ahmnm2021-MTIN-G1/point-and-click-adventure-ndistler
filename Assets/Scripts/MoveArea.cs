using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArea : MonoBehaviour
{
    public PlayerMovementClick PlayerMovementClick;
    public void OnMouseDown()
    {
        PlayerMovementClick.SetNewDestination();
        Debug.Log("Click erkannt");
    }
}
