using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizer : MonoBehaviour
{

    public int hairIndex;
    InitializeCharacter characterInitialization;

    public Sprite[] baseSprites;
    public Sprite[] hairstyles;

    // Start is called before the first frame update
    void Start()
    {
        hairIndex = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(hairIndex == -1)
        {
            hairIndex = characterInitialization.hairIndex;
        }
    }

    public void HairstyleChange(bool up)
    {
        if(up)
        {

        }

    }
}
