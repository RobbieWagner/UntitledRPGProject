using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorContainer : MonoBehaviour
{

    public int colorIndex;
    public CharacterCustomizer characterCustomizer;

    // Start is called before the first frame update
    void Start()
    {
        colorIndex = Random.Range(0, characterCustomizer.colors.Length);
        characterCustomizer.ColorChange(this.gameObject, true);
    }
}
