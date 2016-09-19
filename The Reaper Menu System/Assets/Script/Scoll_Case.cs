using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoll_Case : MonoBehaviour {
    public ScrollRect scroll;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

    public void scrollRight()
    {
        if(scroll.horizontalNormalizedPosition <= 1)
        scroll.horizontalNormalizedPosition += 0.25f;
    
    }

    public void scrollLeft()
    {
        if (scroll.horizontalNormalizedPosition >= 0)
            scroll.horizontalNormalizedPosition -= 0.25f;
    }
}
