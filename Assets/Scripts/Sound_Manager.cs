using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    public GameObject uiManagerGO;

    public GameObject plusOne;
    public GameObject winSound;

    // Start is called before the first frame update
    void Start()
    {
        plusOne.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (plusOne.active = true)
        {
            Debug.Log("Sound active");
            winSound.SetActive(true);
        }
    }
}
