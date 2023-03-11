using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Lasp;

public class UIDevicePicker : MonoBehaviour
{
    public GameObject audioVisGroupParent;

    void Awake() {
        CreateDeviceSelectMenu();
    }

    void CreateDeviceSelectMenu()
    {
        var devices = Lasp.AudioSystem.InputDevices;

        if (devices.Any()) {
            foreach (var dev in devices) {
                // menu.AddItem(new GUIContent(dev.Name),
                                // false, OnSelectDevice, dev.ID);
                Debug.Log(dev.Name);
                // audioVisGroupParent.GetComponent<AudioLevelTracker>().TrySelectDevice(dev.ID);
            }
        }
        else {
            // menu.AddItem(Styles.NoDevice, false, null);
        }

        // return menu;
    }
}
