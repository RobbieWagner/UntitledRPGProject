using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MakePlayerPrefab : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if(player == null)
        {
            player = GameObject.Find("player");
        }
    }

    // Update is called once per frame
    public void PrefabPlayer()
    {
        string localPath = "Assets/Resources/Prefabs/" + player.name + ".prefab";

        PrefabUtility.SaveAsPrefabAsset(player, localPath);

    }
}
