using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeCharacter : MonoBehaviour
{

    public CharacterCustomizer characterCustomizer;

    public GameObject player;

    public int elementType;
    public bool typePassed;
    public Sprite[] baseSprites;

    public SpriteRenderer hair;
    public int hairIndex;

    // Start is called before the first frame update
    void Start()
    {
        typePassed = false;
        hairIndex = Random.Range(0, characterCustomizer.hairstyles.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if(typePassed)
        {
            player.GetComponent<SpriteRenderer>().sprite = baseSprites[elementType];
            hair.sprite = characterCustomizer.hairstyles[hairIndex];
            typePassed = false;
        }
    }
}
