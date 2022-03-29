using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunExampleText : MonoBehaviour
{
    public DialogueReader dialogueRead;
    void Start()
    {
        StartCoroutine(dialogueRead.ReadDialogue("Assets/Text/TextExample.txt"));
    }
}
