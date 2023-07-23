using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

class StoryBlock
{
    public string story;
    public string option1_Text;
    public string option2_Text;
    public StoryBlock option1Block;
    public StoryBlock option2Block;

    public StoryBlock (string story, string option1_Text = "", string option2_Text = "", StoryBlock option1Block = null, StoryBlock option2Block = null)
    {
        this.story = story;
        this.option1_Text = option1_Text;
        this.option2_Text = option2_Text;
        this.option1Block = option1Block;
        this.option2Block = option2Block;
    }
}

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI mainText;
    public Button option1;
    public Button option2;

    StoryBlock block1a_2 = new StoryBlock("You quickly hide the keycard under your mattress and lie down, pretending to be asleep as the footsteps draw nearer. The cell door creaks open, and a guard shines a flashlight into the room, scanning the area. Your heart pounds as you hope the guard doesn't notice anything unusual.");
    StoryBlock block1a_1 = new StoryBlock("You manage to unlock the cell door quietly and step outside. Now you find yourself in a dimly lit corridor.", "Sneak through the corridor", "Attempt to find a weapon or tool");
    StoryBlock block1a = new StoryBlock("You pick up the keycard and notice it has a label with a code written on it. As you examine it further, you hear footsteps approaching the cell.", "Use the keycard", "Hide the keycard and pretend to be asleep");
    StoryBlock block1 = new StoryBlock("You wake up in a dimly lit unlocked cell, disoriented and unsure of how you got here. You notice a small keycard on the floor and a loose brick in the wall.", "Pick up the keycard and examine it", "Inspect the loose brick");

    // Start is called before the first frame update
    void Start()
    {
        mainText.text = "Try to escape my Manor.";
        option1.GetComponentInChildren<TextMeshProUGUI>().text = "Hell yeah";
        option2.GetComponentInChildren<TextMeshProUGUI>().text = "Hell no";
    }



}
