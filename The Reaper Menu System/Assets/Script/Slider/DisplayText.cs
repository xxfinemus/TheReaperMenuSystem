using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayText : MonoBehaviour
{
    private int kittyNum = 16;
    private int maidenNum;

    [SerializeField]
    private Text textToChange;
    [SerializeField]
    private string sliderText;

    void Start()
    {
        textToChange = gameObject.GetComponentInChildren<Text>();
    }


    public void ChangeText()
    {
        textToChange.text = sliderText + kittyNum;
    }

    public void ChangeSliderValue()
    {
        //if (challange completed)
        //{
        //    kittyNum++;
        //}
    }
}
