using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetChangeTarget : MonoBehaviour{

    public GameObject mainCamera;
    public GameObject iconsBrain;
    public GameObject iconsBrainTransp;
    public GameObject ButtonAlt;
    public GameObject ButtonSystem;
    public GameObject thisRef;
    private CameraBehavior behavCamera;

    public Text textRef;
    
    

    private bool defaultTarget = true;

    // Start is called before the first frame update
    void Start(){
        behavCamera = mainCamera.GetComponent<CameraBehavior>();

        focusIcons();
    }

    // Update is called once per frame
    void Update(){
           
    }

    public void onClickAction(){
        behavCamera.changeTarget();
        defaultTarget = !defaultTarget;
        focusIcons();
    }

    void focusIcons(){
        iconsBrain.SetActive((defaultTarget) ? true : false);
        iconsBrainTransp.SetActive((defaultTarget) ? false : true);
        ButtonAlt.SetActive((defaultTarget) ? true : false);
        ButtonSystem.SetActive((defaultTarget) ? false : true);

        thisRef.GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>().text = (defaultTarget) ? "Partes internas" : "Partes externas";
    }
}
