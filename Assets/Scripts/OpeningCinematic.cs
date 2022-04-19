using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCinematic : MonoBehaviour
{

    public GameObject CompanyLogoReader;
    public PrintToDialogueReader textSender;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisplayOpeningLogo());
    }

    // Update is called once per frame
    void Update()
    {
        if(!textSender.running)
        {
            CompanyLogoReader.SetActive(false);
        }
    }

    IEnumerator DisplayOpeningLogo()
    {
        yield return new WaitForSeconds(3f);
        CompanyLogoReader.SetActive(true);

        yield return StartCoroutine(textSender.SendDialogue());

        StopCoroutine(DisplayOpeningLogo());
    }
}
