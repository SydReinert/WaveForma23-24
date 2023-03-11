using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideCredits : MonoBehaviour
{
    bool on = false;
    public GameObject credits;

    public void ToggleCredits() {
        Debug.Log("yes");
        if (on) {
            credits.SetActive(false);
            on = false;
            return;
        }
        if (!on) {
            credits.SetActive(true);
            on = true;
            return;
        }
    }
}
