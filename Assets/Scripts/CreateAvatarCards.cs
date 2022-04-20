using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAvatarCards : MonoBehaviour
{
    GameObject hasOpeningCinematic;
    OpeningCinematic openingCinematic;
    public GameObject airAvatarCard;
    public GameObject button;
    public GameObject selectElementText;

    void Start()
    {
        hasOpeningCinematic = GameObject.Find("RunsOpeningCinematic(Clone)");

        if(hasOpeningCinematic != null)
        {
            openingCinematic = hasOpeningCinematic.GetComponent<OpeningCinematic>();
        }
    }

    public void buttonPressed()
    {
        if(openingCinematic != null && openingCinematic.timesBooted == 0)
        {
            Instantiate(airAvatarCard);
            selectElementText.SetActive(true);
        }

        button.SetActive(false);
    }

}
