using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintToDialogueReader : MonoBehaviour
{
    public DialogueReader dialogueRead;
    public string path;

    public bool running;

    void Awake()
    {
        running = true;
    }

    public IEnumerator SendDialogue()
    {
        yield return StartCoroutine(dialogueRead.ReadDialogue(path));
        running = false;
        StopCoroutine(SendDialogue());
    }
}
