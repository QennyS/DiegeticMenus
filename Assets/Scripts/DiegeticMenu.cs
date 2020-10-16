using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiegeticMenu : MonoBehaviour
{

    private Canvas canvas;
    public CanvasGroup Panel;
    private bool start_layer = false;
    private bool option_layer = false;
    private bool sound_layer = false;

    // Start is called before the first frame update
    void Start()
    {
    
        start_layer = true;
        GameObject tempObject = GameObject.Find("Tablet");
        if (tempObject != null)
        {
            //If we found the object , get the Canvas component from it.
            canvas = tempObject.GetComponent<Canvas>();
        }
        Panel = canvas.GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartMenu()
    {
        if(start_layer){
            Panel.alpha = 0.0f; 
        }
    }
}