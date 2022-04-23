using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InitializeCharacter : MonoBehaviour
{

    public CharacterCustomizer characterCustomizer;

    public GameObject player;

    public int elementType;
    public bool typePassed;
    public Sprite[] baseSprites;

    public SpriteRenderer hair;
    public ClothingInfo hairInfo;

    public SpriteRenderer top;
    public ClothingInfo topInfo;

    public SpriteRenderer bottom;
    public ClothingInfo bottomInfo;

    public SpriteRenderer shoe;
    public ClothingInfo shoeInfo;

    public TMP_Text hairstyleLabel;
    public TMP_Text topLabel;
    public TMP_Text bottomLabel;
    public TMP_Text shoeLabel;

    // Start is called before the first frame update
    void Start()
    {
        typePassed = false;

        if(player != null)
        {
            hairInfo.clothingIndex = Random.Range(0, characterCustomizer.hairstyles.Length);
            topInfo.clothingIndex = Random.Range(0, characterCustomizer.tops.Length);
            bottomInfo.clothingIndex = Random.Range(0, characterCustomizer.bottoms.Length);
            shoeInfo.clothingIndex = Random.Range(0, characterCustomizer.shoes.Length);

            hairInfo.colorIndex = Random.Range(0, characterCustomizer.colors.Length);
            characterCustomizer.ColorChange(hairInfo.gameObject, true);

            topInfo.colorIndex = Random.Range(0, characterCustomizer.colors.Length);
            characterCustomizer.ColorChange(topInfo.gameObject, true);

            bottomInfo.colorIndex = Random.Range(0, characterCustomizer.colors.Length);
            characterCustomizer.ColorChange(bottomInfo.gameObject, true);

            shoeInfo.colorIndex = Random.Range(0, characterCustomizer.colors.Length);
            characterCustomizer.ColorChange(shoeInfo.gameObject, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player !=null && typePassed)
        {
            player.GetComponent<SpriteRenderer>().sprite = baseSprites[elementType];
            hair.sprite = characterCustomizer.hairstyles[hairInfo.clothingIndex];
            top.sprite = characterCustomizer.tops[topInfo.clothingIndex];
            bottom.sprite = characterCustomizer.bottoms[bottomInfo.clothingIndex];
            shoe.sprite = characterCustomizer.shoes[shoeInfo.clothingIndex];
            typePassed = false;
        }
    }
}
