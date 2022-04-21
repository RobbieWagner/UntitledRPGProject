using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeCharacter : MonoBehaviour
{

    public int elementType;
    public bool typePassed;
    public Sprite[] baseSprites;

    public SpriteRenderer hair;
    public int hairIndex;
    public Sprite[] hairstyles;

    // Start is called before the first frame update
    void Start()
    {
        typePassed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(typePassed)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = baseSprites[elementType];
            hairIndex = Random.Range(0, hairstyles.Length);
            hair.sprite = hairstyles[hairIndex];
            typePassed = false;
        }
    }
}
