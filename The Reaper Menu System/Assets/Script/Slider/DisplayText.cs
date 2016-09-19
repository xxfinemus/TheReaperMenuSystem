using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayText : MonoBehaviour
{
    private int kittyNum = 20;
    private int maidenNum;
    private Text textToChange;
    private Slider sliderToChange;

    [SerializeField]
    private string sliderText;


    void Start()
    {
        textToChange = gameObject.GetComponentInChildren<Text>();
        sliderToChange = gameObject.GetComponent<Slider>();

        ChangeText();
        ChangeSliderValue();
    }


    public void ChangeText()
    {
        textToChange.text = sliderText + kittyNum + " x";
    }

    public void ChangeSliderValue()
    {
        //if (challange completed)
        //{
        //    kittyNum++;
        //}
        //OR if Challange completed
        //      kittyNum = NewNumber;
        //      ChangeText();

        sliderToChange.value = kittyNum;
    }


}
