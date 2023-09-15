using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChange : MonoBehaviour
{
    [SerializeField] private TMP_Text randomText;
    [SerializeField] private Text randomText2;

    DataController dataController;

    // Start is called before the first frame update
    void Start()
    {
        randomText.text = "Hello World";
    }

    public void UpdateText(string newText)
    {
        Debug.Log(newText);
        randomText2.text = newText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
