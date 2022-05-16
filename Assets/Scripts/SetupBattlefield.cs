using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupBattlefield : MonoBehaviour
{

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        player.transform.localScale = new Vector3(.75f, .75f, .75f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
