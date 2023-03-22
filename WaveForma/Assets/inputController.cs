using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class inputController : MonoBehaviour
{
    void Update() {
        if (Input.GetAxis("Switch1") > 0) SceneManager.LoadScene("Visualizer 1");
        if (Input.GetAxis("Switch2") > 0) SceneManager.LoadScene("Visualizer 2");
        if (Input.GetAxis("Switch3") > 0) SceneManager.LoadScene("Visualizer 3");
    }
}
