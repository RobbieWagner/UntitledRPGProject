using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCinematic : MonoBehaviour
{

    public GameObject dandelion;
    public string logoPath;

    public DialogueReader dialogueRead;
    private bool running;

    // Start is called before the first frame update
    void Start()
    {
        running = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // write an algorithm that runs different dialogues right after the other
        // string list of paths. Wait for the last to be over, and maybe a few other things before the next plays
        //used for the opening cinematic. Plays fake company logo, introduction, and then puts up the game menu
}
