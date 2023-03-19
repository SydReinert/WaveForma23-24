using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFade : MonoBehaviour
{
    public string scene;
    public int delay = 60;

    void Start() {
        Invoke("ChangeScene", delay);
    }

    void ChangeScene() {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
