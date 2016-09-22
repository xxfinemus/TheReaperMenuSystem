using UnityEngine;
using System.Collections;

public class StoreOriginalPotition : MonoBehaviour
{
    private RectTransform rect;
    public Vector2 originalPos;

    // Use this for initialization
    void Start()
    {
        rect = GetComponent<RectTransform>();
        originalPos = rect.anchoredPosition;
    }

}
