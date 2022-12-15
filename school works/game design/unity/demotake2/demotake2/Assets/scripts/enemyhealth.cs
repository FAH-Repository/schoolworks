using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemyhealth : MonoBehaviour
{
   
    public int maxhealth = 100;
    public int curhealth = 100;
    Animator anim;

    private GUIStyle currentStyle = null;
    public float healthBarLength;
    public Slider healthSlider;
    // Use this for initialization
    void Start()
    {
        healthBarLength = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        AddjustCurHealth(0);
    }

    //void OnGUI()
    //{
    //    InitStyles();
            
        
    //    GUI.Box(new Rect(1100, 10, healthBarLength, 20),"cube     " + curhealth + "/" + maxhealth, currentStyle);
       

    //}
    //private void InitStyles() {
    //    if (currentStyle == null) {
    //        currentStyle = new GUIStyle(GUI.skin.box);
    //        currentStyle.normal.background = MakeTex(2, 2, new Color(0f, 1f, 0f, 0.5f));
    //    }
    //}
    //private Texture2D MakeTex(int width, int height, Color col) {
    //    Color[] pix = new Color[width * height];
    //    for (int i = 0; i < pix.Length; ++i) {
    //        pix[i] = col;
    //    }
    //    Texture2D result = new Texture2D(width, height);
    //    result.SetPixels(pix);
    //    result.Apply();
    //    return result;
    //}
    public void AddjustCurHealth(int adj)
    {
     
     
        curhealth += adj;

        if (curhealth < 1)
        {
            curhealth = 0;
        }
        if (curhealth > maxhealth)
        {
            curhealth = maxhealth;
        }
        if (maxhealth < 1)
        {
            maxhealth = 1;

        }
        if (curhealth == 0) {
            //    anim.SetTrigger("dead");
        
          
            Destroy(gameObject);
        }

        healthSlider.value = curhealth;
      //  healthBarLength = (Screen.width / 3) * (curhealth / (float)maxhealth);

    }
}
