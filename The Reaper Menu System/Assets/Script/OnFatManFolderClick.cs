using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnFatManFolderClick : MonoBehaviour
{
    private Animator animator;
    private Animation animation;

    [SerializeField]
    private GameObject imageToActivate;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clicked()
    {

    }

    public void RunAnimation()
    {
        animator.SetBool("open", true);

        if (!animation.isPlaying)
        {
            //activate panel
        }
    }

    public void MoveFolder()
    {
        //move the folder
    }

    public void ActivateOverlayImage()
    {
        imageToActivate.SetActive(true);
    }
}
