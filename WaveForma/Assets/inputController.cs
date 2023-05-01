using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class inputController : MonoBehaviour
{

    private GameObject ui;
    private bool uiActivated;

    private GameObject sceneSwitcher;
    private bool sceneSwitcherActivated;

    private void Start()
    {
        ui = GameObject.Find("UI");
        ui.GetComponent<Canvas>().enabled = false;
        uiActivated = true;

        sceneSwitcher = GameObject.Find("SceneSwitcher");
        sceneSwitcherActivated = true;
    }


    void Update() {
        if (Input.GetAxis("Switch1") > 0) SceneManager.LoadScene("Visualizer 1");
        if (Input.GetAxis("Switch2") > 0) SceneManager.LoadScene("Visualizer 2");
        if (Input.GetAxis("Switch3") > 0) SceneManager.LoadScene("Visualizer 3");
        if (Input.GetAxis("Switch4") > 0) SceneManager.LoadScene("Visualizer 4");
        if (Input.GetAxis("Switch5") > 0) SceneManager.LoadScene("Visualizer 5");
        if (Input.GetAxis("Switch6") > 0) SceneManager.LoadScene("Visualizer 6");
        if (Input.GetAxis("Switch7") > 0) SceneManager.LoadScene("Visualizer 7");
        if (Input.GetAxis("Switch8") > 0) SceneManager.LoadScene("Visualizer 8");
        if (Input.GetAxis("Switch9") > 0) SceneManager.LoadScene("Visualizer 9");
        if (Input.GetAxis("Switch0") > 0) SceneManager.LoadScene("Visualizer 10");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (uiActivated)
            {
                ui.GetComponent<Canvas>().enabled = false;
                uiActivated = false;
            }
            else
            {
                ui.GetComponent<Canvas>().enabled = true;
                uiActivated = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (sceneSwitcherActivated)
            {
                sceneSwitcher.GetComponent<SceneFade>().enabled = false;
                sceneSwitcherActivated = false;
                sceneSwitcher.GetComponent<SceneFade>().CancelInvoke();
            }
            else
            {
                sceneSwitcher.GetComponent<SceneFade>().enabled = true;
                sceneSwitcherActivated = true;
                sceneSwitcher.GetComponent<SceneFade>().StartCoroutine("Start");
            }
        }
    }
}
