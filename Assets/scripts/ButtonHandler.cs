using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonHandler : MonoBehaviour
{
    public Main Main;
    public GameObject toggleButton;

    public void ToggleText() {
        Main.toggleText();
    }

    public void ToggleEnable() {
        if (toggleButton.GetComponent<Button>().interactable == false) {
            toggleButton.GetComponent<Button>().interactable = true;
        } else {
            toggleButton.GetComponent<Button>().interactable = false;
        }
    }

    public void PullSlotLever() {
        Main.PullSlotLever();
    }
}
