using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputController : MonoBehaviour
{
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
    }
}
