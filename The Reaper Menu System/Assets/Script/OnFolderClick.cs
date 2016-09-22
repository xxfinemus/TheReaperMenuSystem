using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OnFolderClick : MonoBehaviour
{
    private bool folderIsOpen = false;
    private int distance;

    private GameObject cutOutGameObject;
    private GameObject overlayGameObject;

    private Animation anim;
    private Animator animator;

    private List<RectTransform> children;
    private List<Button> buttons;
    private RectTransform rect;

    [SerializeField]
    private GameObject parentObject;
    [SerializeField]
    private GameObject mainCanvas;

    void Start()
    {
        children = new List<RectTransform>();
        buttons = new List<Button>();

        parentObject.tag = "dontAdd";

        foreach (Button child in mainCanvas.GetComponentsInChildren<Button>())
        {
            buttons.Add(child);
        }

    }
    public void StoreOverlayObject(GameObject overlayGameObject)
    {
        this.overlayGameObject = overlayGameObject;
        animator = overlayGameObject.GetComponent<Animator>();
        overlayGameObject.tag = "dontAdd";
    }

    public void StoreObject(GameObject cutOutGameObject)
    {
        this.cutOutGameObject = cutOutGameObject;
        rect = cutOutGameObject.GetComponent<RectTransform>();
        cutOutGameObject.tag = "dontAdd";
    }

    public void StoreDistanceToMove(int distance)
    {
        this.distance = distance;
    }

    public void Clicked()
    {
        if (!folderIsOpen)
        {
            StartCoroutine(OpenFolder());
        }
        else
        {
            StartCoroutine(CloseFolder());
        }
    }

    private IEnumerator OpenFolder()
    {
        return null;
    }

    private IEnumerator CloseFolder()
    {
        return null;
    }

    private void HandleButtons(bool enable)
    {
        if (enable)
        {
            foreach (Button child in buttons)
            {
                child.interactable = true;
            }
        }

        else
        {
            foreach (Button child in buttons)
            {
                child.interactable = false;
            }
        }
    }

    public void RunAnimation(bool isFolderOpen)
    {

        if (!isFolderOpen)
        {
            animator.SetBool("open", true);
            animator.SetBool("opened", true);
        }

        else
        {
            animator.SetBool("open", false);
            animator.SetBool("opened", false);
        }
    }

    public void MoveFolder(bool clicked)
    {
        StoreOriginalPotition childOriPos;

        foreach (RectTransform child in parentObject.GetComponentsInChildren<RectTransform>())
        {
            children.Add(child);

            if (child.tag == "dontAdd")
            {
                children.Remove(child);
            }
        }        

        if (clicked)
        {
            foreach (RectTransform child in children)
            {
                if (child.anchoredPosition.x > rect.anchoredPosition.x)
                {
                    child.anchoredPosition = new Vector2(child.anchoredPosition.x - distance, child.anchoredPosition.y);
                }

                else if (child.anchoredPosition.x < rect.anchoredPosition.x)
                {
                    child.anchoredPosition = new Vector2(child.anchoredPosition.x + distance, child.anchoredPosition.y);
                }
            }

            rect.anchoredPosition = new Vector2(rect.anchoredPosition.x + distance, rect.anchoredPosition.y);
        }

        else
        {
            foreach (RectTransform child in children)
            {
                if (child.anchoredPosition.x > rect.anchoredPosition.x)
                {
                    childOriPos = child.gameObject.GetComponent<StoreOriginalPotition>();
                    child.anchoredPosition = childOriPos.originalPos;
                }

                else if (child.anchoredPosition.x < rect.anchoredPosition.x)
                {
                    childOriPos = child.gameObject.GetComponent<StoreOriginalPotition>();
                    child.anchoredPosition = childOriPos.originalPos;
                }
            }

            rect.anchoredPosition = new Vector2(rect.anchoredPosition.x - distance, rect.anchoredPosition.y);
        }
    }

    public void OverlayImage(bool active)
    {
        if (!active)
        {
            overlayGameObject.SetActive(true);
            cutOutGameObject.SetActive(false);
        }

        else
        {
            overlayGameObject.SetActive(false);
            cutOutGameObject.SetActive(true);
        }
    }
}
