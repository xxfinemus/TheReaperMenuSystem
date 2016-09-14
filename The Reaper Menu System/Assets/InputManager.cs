using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {
    public GameObject backPanel;
    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
            backToStartMenu();
    }

    public void backToStartMenu()
    {
            if(backPanel.activeSelf)
            {
                backPanel.SetActive(false);
            }
            else
                backPanel.SetActive(true);
        }
    }

