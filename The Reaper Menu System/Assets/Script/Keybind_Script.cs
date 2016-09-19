using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Keybind_Script : MonoBehaviour {
    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    public Text zoomIn, rotateLeft, zoomOut, rotateRight, move;

    private GameObject currentKey;

    Color32 normal = new Color32(39, 171, 249, 255);

    Color32 selected = new Color32(239, 116, 36, 255);
	// Use this for initialization
	void Start () {
        keys.Add("Zoom In", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Zoom In", "W")));
        keys.Add("Rotate Left", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Rotate Left", "A")));
        keys.Add("Rotate Right", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Rotate Right", "D")));
        keys.Add("Zoom Out", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Zoom Out", "S")));
        keys.Add("Move", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Move", "Mouse0")));

        zoomIn.text = keys["Zoom In"].ToString();
        rotateLeft.text = keys["Rotate Left"].ToString();
        rotateRight.text = keys["Rotate Right"].ToString();
        zoomOut.text = keys["Zoom Out"].ToString();
        move.text = keys["Move"].ToString();
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(keys["Zoom In"]))
        {
            Debug.Log("Zoom In");
        }
        if (Input.GetKeyDown(keys["Rotate Left"]))
        {
            Debug.Log("Rotate Left");
        }
        if (Input.GetKeyDown(keys["Rotate Right"]))
        {
            Debug.Log("Rotate Right");
        }
        if (Input.GetKeyDown(keys["Zoom Out"]))
        {
            Debug.Log("Zoom Out");
        }
        if (Input.GetKeyDown(keys["Move"]))
        {
            Debug.Log("Move");
        }



    }

    void OnGUI()
    {
        if (currentKey != null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                keys[currentKey.name] = e.keyCode;
                currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                currentKey.GetComponent<Image>().color = normal;
                currentKey = null;
            }

            if (e.isMouse)
            {
                switch (e.button)
                {
                    case 0:
                        keys[currentKey.name] = KeyCode.Mouse0;
                        currentKey.transform.GetChild(0).GetComponent<Text>().text = "Mouse 0";
                        break;
                    case 1:
                        keys[currentKey.name] = KeyCode.Mouse1;
                        currentKey.transform.GetChild(0).GetComponent<Text>().text = "Mouse 1";
                        break;

                }

                currentKey.GetComponent<Image>().color = normal; //Sets thecolor
                currentKey = null; //Deselects the key
            }﻿
        }
    }

    public void changeKey(GameObject clicked)
    {
        if (currentKey != null)
        {
            currentKey.GetComponent<Image>().color = normal;
        }
        currentKey = clicked;
        currentKey.GetComponent<Image>().color = selected;
    }

    public void savedKeys()
    {
        foreach (var key in keys)
        {
            PlayerPrefs.SetString(key.Key, key.Value.ToString());
        }

        PlayerPrefs.Save();
        
    }
}
