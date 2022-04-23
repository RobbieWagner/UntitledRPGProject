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
    public int hairIndex;
    bool changedHairstyle;

    public SpriteRenderer top;
    public int topIndex;
    bool changedTop;

    public SpriteRenderer bottom;
    public int bottomIndex;
    bool changedBottom;

    public SpriteRenderer shoe;
    public int shoeIndex;
    bool changedShoes;

    public TMP_Text hairstyleLabel;
    public TMP_Text topLabel;
    public TMP_Text bottomLabel;
    public TMP_Text shoeLabel;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        player.transform.localScale = new Vector3(1.5f, 1.5f, transform.localScale.z);

        //get the right index
        hairstyleLabel.text = "Hair No. " + (hairIndex + 1);
        topLabel.text = "Top No. " + (topIndex + 1);
        bottomLabel.text = "Bottoms No. " + (bottomIndex + 1);
        shoeLabel.text = "Shoes No. " + (shoeIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(changedHairstyle) hair.sprite = hairstyles[hairIndex];
        if(changedTop) top.sprite = tops[topIndex];
        if(changedBottom) bottom.sprite = bottoms[bottomIndex];
        if(changedShoes) shoe.sprite = shoes[shoeIndex];
    }

    public void HairstyleChange(bool up)
    {
        if(up)
        {
            if(hairIndex == hairstyles.Length-1) hairIndex = 0;
            else hairIndex++;
            changedHairstyle = true;
        }
        else
        {
            if(hairIndex == 0) hairIndex = hairstyles.Length-1;
            else hairIndex--;
            changedHairstyle = true;
        }

        hairstyleLabel.text = "Hair No. " + hairIndex;

    }

    public void TopChange(bool up)
    {
        if(up)
        {
            if(topIndex == tops.Length-1) topIndex = 0;
            else topIndex++;
            changedTop = true;
        }
        else
        {
            if(topIndex == 0) topIndex = tops.Length-1;
            else topIndex--;
            changedTop = true;
        }

        topLabel.text = "Top No. " + topIndex;
    }

    public void BottomChange(bool up)
    {
        if(up)
        {
            if(bottomIndex == bottoms.Length-1) bottomIndex = 0;
            else bottomIndex++;
            changedBottom = true;
        }
        else
        {
            if(bottomIndex == 0) bottomIndex = bottoms.Length-1;
            else bottomIndex--;
            changedBottom = true;
        }

        bottomLabel.text = "Bottoms No. " + bottomIndex;

    }

    public void ShoeChange(bool up)
    {
        if(up)
        {
            if(shoeIndex == shoes.Length-1) shoeIndex = 0;
            else shoeIndex++;
            changedShoes = true;
        }
        else
        {
            if(shoeIndex == 0) shoeIndex = shoes.Length-1;
            else shoeIndex--;
            changedShoes = true;
        }

        shoeLabel.text = "Shoes No. " + shoeIndex;

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
