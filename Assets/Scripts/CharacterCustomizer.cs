using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizer : MonoBehaviour
{
    public GameObject player;

    public InitializeCharacter characterInitialization;

    public Sprite[] hairstyles;
    public Sprite[] tops;
    public Sprite[] bottoms;
    public Sprite[] shoes;

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

        if(topIndex == -1)
        {
            topIndex = characterInitialization.topIndex;
        }

        if(bottomIndex == -1)
        {
            bottomIndex = characterInitialization.bottomIndex;
        }

        if(shoeIndex == -1)
        {
            shoeIndex = characterInitialization.shoeIndex;
        }

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

    public void TopChange(bool up)
    {
        if(up)
        {
            if(topIndex == tops.Length-1) topIndex = 0;
            else topIndex ++;
            changedTop = true;
        }
        else
        {
            if(topIndex == 0) topIndex = tops.Length-1;
            else topIndex--;
            changedTop = true;
        }

    }

    public void BottomChange(bool up)
    {
        if(up)
        {
            if(bottomIndex == bottoms.Length-1) bottomIndex = 0;
            else bottomIndex ++;
            changedBottom = true;
        }
        else
        {
            if(bottomIndex == 0) bottomIndex = bottoms.Length-1;
            else bottomIndex--;
            changedBottom = true;
        }

    }

    public void ShoeChange(bool up)
    {
        if(up)
        {
            if(shoeIndex == shoes.Length-1) shoeIndex = 0;
            else shoeIndex ++;
            changedShoes = true;
        }
        else
        {
            if(shoeIndex == 0) shoeIndex = shoes.Length-1;
            else shoeIndex--;
            changedShoes = true;
        }

    }
}
