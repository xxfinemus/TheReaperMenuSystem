using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class graphicsScript : MonoBehaviour {
    public Canvas deskCanvas;
    float height;
    float width;
	// Use this for initialization
	void Start () {
        deskCanvas.GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setRessolution()
    {
        height = Camera.main.orthographicSize * 2;
        width = height * Screen.width / Screen.height; // basically height * screen aspect ratio
        int length = gameObject.transform.childCount;
        for (int i = 0; i <length; i++)
			{
                gameObject.transform.GetChild(i).localScale = Vector3.one * height / 20f;
			}
        
    }
}
