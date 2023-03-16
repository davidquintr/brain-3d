using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ActivityListener : MonoBehaviour{

    public GameObject brainPart;
    public GameObject thisImageRef;
    public Sprite imageStand;
    public Sprite imageFocus;
    
    private ClickDetect brainBehav;
    private Image thisImagePars;


    // Start is called before the first frame update
    void Start(){
        brainBehav = brainPart.GetComponent<ClickDetect>();
        thisImagePars = thisImageRef.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update(){

        if (brainBehav.active){
            thisImagePars.sprite = imageFocus;
        }
        else{
            thisImagePars.sprite = imageStand;
        }
        
    }
}
