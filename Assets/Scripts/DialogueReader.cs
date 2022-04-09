using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueReader : MonoBehaviour
{

    public TextMeshProUGUI dialogueText;

    public IEnumerator ReadDialogue(StreamReader dialogueReader)
    {

        string line;

        while((line = dialogueReader.ReadLine()) != " ")
        {
            dialogueText.text = line;
            yield return new WaitForSeconds(.25f);
            while((line = dialogueReader.ReadLine()) != "~")
            {
                dialogueText.text = line;
                yield return new WaitForSeconds(.25f);
            }
        }

        dialogueText.text = "";
        StopCoroutine(ReadDialogue(dialogueReader));
    }

    public IEnumerator ReadDialogue(string path)
    {
        StreamReader dialogueReader = new StreamReader(path);
        string line;

        while((line = dialogueReader.ReadLine()) != " ")
        {
            dialogueText.text = line;
            yield return new WaitForSeconds(.35f);
            while((line = dialogueReader.ReadLine()) != "~")
            {
                dialogueText.text = line;
                yield return new WaitForSeconds(.35f);
            }
        }

        dialogueText.text = "";
        StopCoroutine(ReadDialogue(path));
    }

    public IEnumerator ReadDialogue(string path, bool running)
    {
        running = true;
        StreamReader dialogueReader = new StreamReader(path);
        string line;

        while((line = dialogueReader.ReadLine()) != " ")
        {
            dialogueText.text = line;
            yield return new WaitForSeconds(.35f);
            while((line = dialogueReader.ReadLine()) != "~")
            {
                dialogueText.text = line;
                yield return new WaitForSeconds(.35f);
            }
        }

        dialogueText.text = "";
        running = false;
        StopCoroutine(ReadDialogue(path));
    }

}
