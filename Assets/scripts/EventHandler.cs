using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{
    public SlotRoller slotRoller0;
    public SlotRoller slotRoller1;
    public SlotRoller slotRoller2;
    public GameObject main;

    private bool lock1;
    private bool lock2;

    // Start is called before the first frame update
    void Start()
    {
        lock1 = true;
        GameObject window1 = GameObject.Find("SlotWindow0");
        slotRoller0 = window1.GetComponent<SlotRoller>();
        slotRoller0.StopRoll += HandleStopRoll;

        lock2 = true;
        GameObject window2 = GameObject.Find("SlotWindow1");
        slotRoller1 = window2.GetComponent<SlotRoller>();
        slotRoller1.StopRoll += HandleStopRoll;

        GameObject window3 = GameObject.Find("SlotWindow2");
        slotRoller2 = window3.GetComponent<SlotRoller>();
        slotRoller2.StopRoll += HandleStopRoll;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleStopRoll() {
        if (lock1) {
            lock1 = false;
        } else if (lock2) {
            lock2 = false;
        } else {
            lock1 = true;
            lock2 = true;
            main.GetComponent<Main>().EnableLever();
        }
     }
}
