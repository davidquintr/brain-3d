using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternBloom : MonoBehaviour
{

    public GameObject post;
    public bool defaultVal;
    
    void Start()
    {
        
    }
    
    public void altern(){
        defaultVal = !defaultVal;
        post.SetActive((defaultVal ? true : false));
    }
}
