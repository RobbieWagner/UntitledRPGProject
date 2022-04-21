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

    public SpriteRenderer top;
    public int topIndex;

    public SpriteRenderer bottom;
    public int bottomIndex;

    public SpriteRenderer shoe;
    public int shoeIndex;

    // Start is called before the first frame update
    void Start()
    {
        typePassed = false;
        hairIndex = Random.Range(0, characterCustomizer.hairstyles.Length);
        topIndex = Random.Range(0, characterCustomizer.tops.Length);
        bottomIndex = Random.Range(0, characterCustomizer.bottoms.Length);
        shoeIndex = Random.Range(0, characterCustomizer.shoes.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if(typePassed)
        {
            player.GetComponent<SpriteRenderer>().sprite = baseSprites[elementType];
            hair.sprite = characterCustomizer.hairstyles[hairIndex];
            top.sprite = characterCustomizer.tops[topIndex];
            bottom.sprite = characterCustomizer.bottoms[bottomIndex];
            shoe.sprite = characterCustomizer.shoes[shoeIndex];
            typePassed = false;
        }
    }
}
