using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Interact_Functionallity : MonoBehaviour
{
    public GameObject newPosition;
    public Animator caseAnimate;
    GameObject[] butt;

    // Use this for initialization
    void Start()
    {
        //int i = 0;
        //butt = new GameObject[10];

        //object[] obj = GameObject.FindObjectsOfType(typeof(GameObject));
        //foreach (object o in obj)
        //{
        //    GameObject g = (GameObject)o;
        //    if(g.GetComponent<Button>() == true)
        //    {
        //        butt[i] = g;
        //        i++;
        //    }
        // }
       
    }

    // Update is called once per frame
    void Update()
    {

        //if (!caseAnimate.GetBool("isStaticAnim"))
        //{
        //    pauseButtonInteractions();
        //}
        //else
        //    for (int i = 0; i < butt.Length; i++)
        //    {
        //        butt[i].GetComponent<Button>().interactable = true;
        //    }

    }

    void pauseButtonInteractions()
    {
        //for (int i = 0; i < butt.Length; i++)
        //{
        //    butt[i].GetComponent<Button>().interactable = false;
        //}
    }

    public void moveCase(GameObject objectToMove)
    {
      
    }
}
