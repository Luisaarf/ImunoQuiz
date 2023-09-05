using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{
    
    [SerializeField] private Sprite volumeIcon;
    [SerializeField] private TextAsset textJSON;
    void Start()
    {
        LoadGameData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadGameData()
    {
       JSONDATA = JsonUtility.FromJson<PlayerList>(textJSON.text);
       System.Console.WriteLine(JSONDATA);
    }
}
