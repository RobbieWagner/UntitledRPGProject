using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeCharacter : MonoBehaviour
{

    CharacterCustomizer characterCustomizer;

    public GameObject player;

    public int elementType;
    public bool typePassed;
    Sprite[] baseSprites;

    SpriteRenderer hair;
    public int hairIndex;
    Sprite[] hairstyles;

    // Start is called before the first frame update
    void Start()
    {
        typePassed = false;
        hairIndex = Random.Range(0, hairstyles.Length);

        baseSprites = characterCustomizer.baseSprites;
        hairstyles = characterCustomizer.hairstyles;
    }

    // Update is called once per frame
    void Update()
    {
        if(typePassed)
        {
            player.GetComponent<SpriteRenderer>().sprite = baseSprites[elementType];
            hair.sprite = hairstyles[hairIndex];
            typePassed = false;
        }
    }
}
