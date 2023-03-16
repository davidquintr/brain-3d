using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HideBrain : MonoBehaviour
{

    public GameObject BrainTransparent;
    public GameObject thisRef;
    public bool defaultHide = false;
    
    void Start(){
        onClickHide();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickHide(){
        defaultHide = !defaultHide;
        BrainTransparent.SetActive(defaultHide);
        thisRef.GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>().text = (defaultHide) ? "Interior" : "Exterior";
    }
}
