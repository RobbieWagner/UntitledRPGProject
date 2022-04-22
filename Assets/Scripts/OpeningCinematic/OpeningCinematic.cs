using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningCinematic : MonoBehaviour
{

    public GameObject CompanyLogoReader;
    public PrintToDialogueReader textSender;
    private string nextScene;
    public int timesBooted = 0;

    public GameObject airAvatarCard;
    public GameObject earthAvatarCard;
    public GameObject fireAvatarCard;
    public GameObject waterAvatarCard;
    public GameObject lifeAvatarCard;
    public GameObject deathAvatarCard;
    public GameObject voidAvatarCard;
    public GameObject energyAvatarCard;
    public GameObject lightAvatarCard;
    public GameObject darkAvatarCard;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(StartGame());
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(!textSender.running && CompanyLogoReader != null)
        {
            CompanyLogoReader.SetActive(false);
        }
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(3f);
        CompanyLogoReader.SetActive(true);

        yield return StartCoroutine(textSender.SendDialogue());

        nextScene = "MenuScreen";
        SceneManager.LoadScene(nextScene);

        StopCoroutine(StartGame());
    }
}
