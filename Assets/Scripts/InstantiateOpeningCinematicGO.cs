using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOpeningCinematicGO : MonoBehaviour
{

    public GameObject openingCinematicPrefab;
    private GameObject openingCinematicGO;
    OpeningCinematic openingCinematic;

    public PrintToDialogueReader textSender;
    public GameObject CompanyLogoReader;

    void Start()
    {
        openingCinematicGO = GameObject.Find("RunsOpeningingCinematic(Clone)");
        if(openingCinematicGO == null) openingCinematicGO = Instantiate(openingCinematicPrefab);

        openingCinematic = openingCinematicGO.GetComponent<OpeningCinematic>();
        openingCinematic.textSender = textSender;
        openingCinematic.CompanyLogoReader = CompanyLogoReader;
    }
}
