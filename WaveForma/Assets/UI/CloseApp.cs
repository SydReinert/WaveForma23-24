using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApp : MonoBehaviour
{
     void Quit() {
         Application.Quit();
         Debug.Log("Quit");
     }
}
