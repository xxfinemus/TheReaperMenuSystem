using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class graphicsScript : MonoBehaviour {
    public Dropdown resOptions;
    bool fullScreenBool;
    bool check = false;
    public Toggle fullScreenTog;
    //public GameObject canvas4x3;
    //public GameObject canvas16x9;
    //public GameObject canvas16x10;
    int hight;
    int width;
	// Use this for initialization
    void Start()
    {

    //    // set the desired aspect ratio (the values in this example are
    //    // hard-coded for 16:9, but you could make them into public
    //    // variables instead so you can set them at design time)
    //    float targetaspect = 16.0f / 9.0f;

    //    // determine the game window's current aspect ratio
    //    float windowaspect = (float)Screen.width / (float)Screen.height;

    //    // current viewport height should be scaled by this amount
    //    float scaleheight = windowaspect / targetaspect;

    //    // obtain camera component so we can modify its viewport
    //    Camera camera = GetComponent<Camera>();

    //    // if scaled height is less than current height, add letterbox
    //    if (scaleheight < 1.0f)
    //    {
    //        Rect rect = camera.rect;

    //        rect.width = 1.0f;
    //        rect.height = scaleheight;
    //        rect.x = 0;
    //        rect.y = (1.0f - scaleheight) / 2.0f;

    //        camera.rect = rect;
    //    }
    //    else // add pillarbox
    //    {
    //        float scalewidth = 1.0f / scaleheight;

    //        Rect rect = camera.rect;

    //        rect.width = scalewidth;
    //        rect.height = 1.0f;
    //        rect.x = (1.0f - scalewidth) / 2.0f;
    //        rect.y = 0;

    //        camera.rect = rect;
    //    }

    }

    public void changeRes()
    {        
        switch (resOptions.value)
        {
            case 0:
                hight = 1920;
                width = 1080;
                
                //canvas16x9.SetActive(true);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 1:
                hight = 1680;
                width = 1050;
               
                //canvas16x9.SetActive(false);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(true);
                break;
            case 2:
                hight = 1600;
                width = 900;
              
                // canvas4x3.SetActive(true);
                //canvas16x9.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 3:
                hight = 1440;
                width = 900;
                   
                //canvas16x9.SetActive(true);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 4:
                hight = 1400;
                width = 1050;

                //canvas16x9.SetActive(true);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 5:
                hight = 1366;
                width = 768;

                //canvas16x9.SetActive(false);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(true);
                break;
            case 6:
                hight = 1360;
                width = 768;

                // canvas4x3.SetActive(true);
                //canvas16x9.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 7:
                hight = 1280;
                width = 1024;

                //canvas16x9.SetActive(true);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 8:
                hight = 1280;
                width = 960;

                //canvas16x9.SetActive(true);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 9:
                hight = 1280;
                width = 800;

                //canvas16x9.SetActive(false);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(true);
                break;
            case 10:
                hight = 1280;
                width = 768;

                // canvas4x3.SetActive(true);
                //canvas16x9.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 11:
                hight = 1280;
                width = 720;

                //canvas16x9.SetActive(true);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 12:
                hight = 1280;
                width = 600;

                //canvas16x9.SetActive(true);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 13:
                hight = 1152;
                width = 864;

                //canvas16x9.SetActive(false);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(true);
                break;
            case 14:
                hight = 1024;
                width = 768;

                // canvas4x3.SetActive(true);
                //canvas16x9.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 15:
                hight = 800;
                width = 600;

                //canvas16x9.SetActive(true);
                //canvas4x3.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            case 16:
                hight = 640;
                width = 480;

                // canvas4x3.SetActive(true);
                //canvas16x9.SetActive(false);
                //canvas16x10.SetActive(false);
                break;
            default:
                break;
        }
      Screen.SetResolution(hight, width, fullScreenTog);
                Screen.fullScreen = fullScreenTog.isOn;
    
       
       // SceneManager.LoadScene(0);
    }

    public void fullScreen()
    {
        if (fullScreenTog)
            fullScreenBool = true;
        else if(!fullScreenTog)
            fullScreenBool = false;
    }

    public void isDisplayed(GameObject thisObject)
{
       
        if(check == true)
        {
             thisObject.SetActive(false);
                 check = false;
        }
        else if(check == false)
        {
            thisObject.SetActive(true);
            check = true;
        }
}

}
