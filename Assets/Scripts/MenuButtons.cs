using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private string nameSceneToLoad;
    [SerializeField] private Sprite volumeIcon;
    [SerializeField] private Sprite muteIcon;
    [SerializeField] private Button volumeButton;

    void Start()
    {
        volumeButton.GetComponent<Image>().sprite = volumeIcon;
    }
    
    public void ChangeButtonSprite()
    {
        if (volumeButton.GetComponent<Image>().sprite == volumeIcon)
        {
            volumeButton.GetComponent<Image>().sprite = muteIcon;
        }
        else
        {
            volumeButton.GetComponent<Image>().sprite = volumeIcon;
        }
    }

    public void GameNavigation()
    {
        SceneManager.LoadScene(nameSceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
