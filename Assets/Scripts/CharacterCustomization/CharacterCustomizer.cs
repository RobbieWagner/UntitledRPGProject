using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterCustomizer : MonoBehaviour
{
    //handles all of the character customization options including color or clothing and clothing options

    public GameObject player;

    public Sprite[] hairstyles;
    public Sprite[] tops;
    public Sprite[] bottoms;
    public Sprite[] shoes;

    public Color[] colors;
    public int colorIndex;

    public SpriteRenderer hair;
    public ClothingInfo hairInfo;
    bool changedHairstyle;

    public SpriteRenderer top;
    public ClothingInfo topInfo;
    bool changedTop;

    public SpriteRenderer bottom;
    public ClothingInfo bottomInfo;
    bool changedBottom;

    public SpriteRenderer shoe;
    public ClothingInfo shoeInfo;
    bool changedShoes;

    public TMP_Text hairstyleLabel;
    public TMP_Text topLabel;
    public TMP_Text bottomLabel;
    public TMP_Text shoeLabel;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");

        player.transform.localScale = new Vector3(1.5f, 1.5f, transform.localScale.z);

        //get the right index
        hairstyleLabel.text = "Hair No. " + (hairInfo.clothingIndex + 1);
        topLabel.text = "Top No. " + (topInfo.clothingIndex + 1);
        bottomLabel.text = "Bottoms No. " + (bottomInfo.clothingIndex + 1);
        shoeLabel.text = "Shoes No. " + (shoeInfo.clothingIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(changedHairstyle) hair.sprite = hairstyles[hairInfo.clothingIndex];
        if(changedTop) top.sprite = tops[topInfo.clothingIndex];
        if(changedBottom) bottom.sprite = bottoms[bottomInfo.clothingIndex];
        if(changedShoes) shoe.sprite = shoes[shoeInfo.clothingIndex];
    }

    public void HairstyleChange(bool up)
    {
        if(up)
        {
            if(hairInfo.clothingIndex == hairstyles.Length-1) hairInfo.clothingIndex = 0;
            else hairInfo.clothingIndex++;
            changedHairstyle = true;
        }
        else
        {
            if(hairInfo.clothingIndex == 0) hairInfo.clothingIndex = hairstyles.Length-1;
            else hairInfo.clothingIndex--;
            changedHairstyle = true;
        }

        hairstyleLabel.text = "Hair No. " + (hairInfo.clothingIndex + 1);

    }

    public void TopChange(bool up)
    {
        if(up)
        {
            if(topInfo.clothingIndex == tops.Length-1) topInfo.clothingIndex = 0;
            else topInfo.clothingIndex++;
            changedTop = true;
        }
        else
        {
            if(topInfo.clothingIndex == 0) topInfo.clothingIndex = tops.Length-1;
            else topInfo.clothingIndex--;
            changedTop = true;
        }

        topLabel.text = "Top No. " + (topInfo.clothingIndex + 1);
    }

    public void BottomChange(bool up)
    {
        if(up)
        {
            if(bottomInfo.clothingIndex == bottoms.Length-1) bottomInfo.clothingIndex = 0;
            else bottomInfo.clothingIndex++;
            changedBottom = true;
        }
        else
        {
            if(bottomInfo.clothingIndex == 0) bottomInfo.clothingIndex = bottoms.Length-1;
            else bottomInfo.clothingIndex--;
            changedBottom = true;
        }

        bottomLabel.text = "Bottoms No. " + (bottomInfo.clothingIndex + 1);

    }

    public void ShoeChange(bool up)
    {
        if(up)
        {
            if(shoeInfo.clothingIndex == shoes.Length-1) shoeInfo.clothingIndex = 0;
            else shoeInfo.clothingIndex++;
            changedShoes = true;
        }
        else
        {
            if(shoeInfo.clothingIndex == 0) shoeInfo.clothingIndex = shoes.Length-1;
            else shoeInfo.clothingIndex--;
            changedShoes = true;
        }

        shoeLabel.text = "Shoes No. " + (shoeInfo.clothingIndex + 1);

    }

    public void ColorChange(GameObject spriteGO, bool up)
    {
        SpriteRenderer sprite = spriteGO.GetComponent<SpriteRenderer>();
        ClothingInfo colorContainer = spriteGO.GetComponent<ClothingInfo>();
        colorIndex = colorContainer.colorIndex;

        if(up)
        {
            if(colorIndex == colors.Length-1) colorIndex = 0;
            else colorIndex++;
        }
        else
        {
            if(colorIndex == 0) colorIndex = colors.Length-1;
            else colorIndex--;
        }

        sprite.color = colors[colorIndex];
        colorContainer.colorIndex = colorIndex;
    }

    public void ColorChange(GameObject button)
    {
        CharacterCustomizerButtonInfo buttonInfo = button.GetComponent<CharacterCustomizerButtonInfo>();
        GameObject spriteGO = buttonInfo.spriteGO;
        SpriteRenderer sprite = spriteGO.GetComponent<SpriteRenderer>();
        bool up = buttonInfo.up;

        ClothingInfo colorContainer = spriteGO.GetComponent<ClothingInfo>();
        colorIndex = colorContainer.colorIndex;

        if(up)
        {
            if(colorIndex == colors.Length-1) colorIndex = 0;
            else colorIndex++;
        }
        else
        { 
            if(colorIndex == 0) colorIndex = colors.Length-1;        
            else colorIndex--;
        }

        sprite.color = colors[colorIndex];
        colorContainer.colorIndex = colorIndex;
    }
}
