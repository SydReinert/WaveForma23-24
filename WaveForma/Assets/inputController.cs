using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputController : MonoBehaviour
{
    private GameObject ui;
    private bool uiActivated;

    //private GameObject visualOne;
    //private GameObject visualTwo;
    //private bool sceneIsActive = true;


    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.Find("UI");
        /*visualOne = GameObject.Find("Visual1");
        visualTwo = GameObject.Find("Visual2");
        uiActivated = true;
*/
    }

    // Update is called once per frame
    void Update()
    {
        //UI Escape View
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (uiActivated)
            {
                ui.SetActive(false);
                uiActivated = false;
            }
            else
            {
                ui.SetActive(true);
                uiActivated = true;
            }
        }

        //Scene Swaps
        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!sceneIsActive)
            {
                visualOne.SetActive(true);
                sceneIsActive = true;
            }
            else
            {
                sceneIsActive = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!sceneIsActive)
            {
                visualTwo.SetActive(true);
                sceneIsActive = true;
            }
            else
            {
                sceneIsActive = false;
            }
        }*/


    }
}
