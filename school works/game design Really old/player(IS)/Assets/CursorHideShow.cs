using UnityEngine;
using System.Collections;

public class CursorHideShow : MonoBehaviour
{
    //public Texture2D crosshairImage;
    bool CursorLocked;

    void Start()
    {
      //  Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = (false);
        CursorLocked = (true);
    }

    void Update()
    {
     
        if (Input.GetKeyDown("escape") && !CursorLocked)
        {
          //  Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = (false);
            CursorLocked = (true);
        }
        else if (Input.GetKeyDown("escape") && CursorLocked)
        {
         //   Cursor.lockState = CursorLockMode.None;
            Cursor.visible = (true);
            CursorLocked = (false);
        }
    }
 //   void OnGUI()
 //   {
 //       float xMin = ( Input.mousePosition.x) - (crosshairImage.width / 2);
 //       float yMin = (Screen.height - Input.mousePosition.y) - (crosshairImage.height / 2);
 //GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
 //   }
}
