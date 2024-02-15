using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour
{
    public GameObject toggleButton;
    public GameObject button;
    public TextMeshProUGUI gameText;
    public GameObject LeverButton;
    public GameObject SlotWindow0;
    public GameObject SlotWindow1;
    public GameObject SlotWindow2;

    // Start is called before the first frame update
    void Start()
    {
        //toggleButton.SetActive(false);
        toggleButton.GetComponent<Button>().interactable = false;
    }

    public void toggleText() {
        if (gameText.text == "Fun With Toggles!") {
            gameText.text = "Un-toggle me!";
        } else {
            gameText.text = "Fun With Toggles!";
        }
    }

    public void PullSlotLever() {
        SlotWindow0.GetComponent<SlotRoller>().RollSlots();
        SlotWindow1.GetComponent<SlotRoller>().RollSlots();
        SlotWindow2.GetComponent<SlotRoller>().RollSlots();
    }

    public void DisableLever() {
        LeverButton.GetComponent<Button>().interactable = false;
    }

    public void EnableLever() {
        LeverButton.GetComponent<Button>().interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
