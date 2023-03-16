using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickDetect : MonoBehaviour
{

    public Camera camaraPrincipal;
    public GameObject attachObj;
    public bool active = false;

    public Material materialGlow;
    public Material materialBasic;
    private Renderer rend;


    // Start is called before the first frame update
    void Start(){
        rend = attachObj.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetMouseButtonDown(0)){
            Ray rayo = camaraPrincipal.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(rayo, out hit))
            {
                if (hit.collider.gameObject == gameObject){
                    if (active == false)
                        active = true;
                    else
                        active = false;
                }
            }
        }
        checkActivity();
    }

    void checkActivity(){
        if (active){
            rend.material = materialGlow;
        } else{
            rend.material = materialBasic;
        }
    }
    
    public void alternActive(){
        active = !active;
    }
}
