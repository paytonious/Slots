using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotRoller : MonoBehaviour
{
    public List<Image> images;
    private int listIndex;
    public float rollDelay;
    public int rollLoops;
    public int variance;
    public Main Main;

    public delegate void SlotRollEnd(); // Event signal that the roll is done
    public event SlotRollEnd StopRoll;

    // Start is called before the first frame update
    void Start()
    {
        listIndex = 0;

        for (int loopCount = 0; loopCount < images.Count; loopCount++) {
            images[loopCount].enabled = false;
        }
        images[listIndex].enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RollSlots() {
        Main.DisableLever(); // Disable lever on roll
        StartCoroutine(RollSlotsLoop(rollDelay));
    }

    IEnumerator RollSlotsLoop(float delayTime) {
        int looplimit = rollLoops * images.Count + Random.Range(0, variance);
        int loopCount;

        for (loopCount =  listIndex; loopCount < looplimit; loopCount++) {
            listIndex = loopCount % images.Count;

            if (listIndex == 0) {
                images[7].enabled = false;
            } else {
                images[listIndex- 1].enabled = false;
            }

            images[listIndex].enabled = true;

            // Delay the loop in Unity
            yield return new WaitForSeconds(delayTime);
        }
        this.StopRoll();
        yield return null;

    }
}

