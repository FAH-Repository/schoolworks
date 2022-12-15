using UnityEngine;
using System.Collections;

public class megacubeHealth : MonoBehaviour
{
    public int maxhealth = 200;
    public int curhealth = 200;
    Animator anim;
    private GUIStyle currentStyle = null;
    public float healthBarLength;
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


    void OnGUI()
    {
        InitStyles();


        GUI.Box(new Rect(1100, 10, healthBarLength, 20), "cube     " + curhealth + "/" + maxhealth, currentStyle);


    }
    private void InitStyles()
    {
        if (currentStyle == null)
        {
            currentStyle = new GUIStyle(GUI.skin.box);
            currentStyle.normal.background = MakeTex(2, 2, new Color(0f, 1f, 0f, 0.5f));
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "fire")
        {
            curhealth -= 10;
        }

    }


    private Texture2D MakeTex(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];
        for (int i = 0; i < pix.Length; ++i)
        {
            pix[i] = col;
        }
        Texture2D result = new Texture2D(width, height);
        result.SetPixels(pix);
        result.Apply();
        return result;
    }
    public void AddjustCurHealth(int adj)
    {


        curhealth += adj;

        if (curhealth < 1)
        {
            curhealth = 0;
            Destroy(gameObject);
        }
        if (curhealth > maxhealth)
        {
            curhealth = maxhealth;
        }
        if (maxhealth < 1)
        {
            maxhealth = 1;
        }
        if (curhealth < 160 && curhealth > 100)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        if (curhealth < 100 && curhealth > 1)
        {

            this.GetComponent<MeshRenderer>().material.color = new Color(250f, 0.3f, 0f);
        }
        if (curhealth < 30)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color(200f, 0f, 0f, 0f);
        }
        if (curhealth == 0)
        {
            anim.SetTrigger("dead");
            Destroy(gameObject);
        }

        healthBarLength = (Screen.width / 3) * (curhealth / (float)maxhealth);

    }




}

