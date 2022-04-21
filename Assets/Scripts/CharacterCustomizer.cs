using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizer : MonoBehaviour
{
    public GameObject player;

    public InitializeCharacter characterInitialization;

    public Sprite[] hairstyles;

    public SpriteRenderer hair;
    public int hairIndex;
    bool changedHairstyle;

    // Start is called before the first frame update
    void Start()
    {
        hairIndex = -1;
        changedHairstyle = false;

        player.transform.localScale = new Vector3(1.5f, 1.5f, transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(hairIndex == -1)
        {
            hairIndex = characterInitialization.hairIndex;
        }

        if(changedHairstyle) hair.sprite = hairstyles[hairIndex];
    }

    public void HairstyleChange(bool up)
    {
        if(up)
        {
            if(hairIndex == hairstyles.Length-1) hairIndex = 0;
            else hairIndex ++;
            changedHairstyle = true;
        }
        else
        {
            if(hairIndex == 0) hairIndex = hairstyles.Length-1;
            else hairIndex--;
            changedHairstyle = true;
        }

    }
}
