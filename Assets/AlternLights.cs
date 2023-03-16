using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternLights : MonoBehaviour
{
    public bool altern = false;
    public GameObject areaMotSup;
    public GameObject areaPreMot;
    public GameObject areaAsocia;
    public GameObject areaMoto;

    private List<ClickDetect> clicker = new List<ClickDetect>();

    void Start()
    {
        clicker.Add(areaMotSup.GetComponent<ClickDetect>());
        clicker.Add(areaPreMot.GetComponent<ClickDetect>());
        clicker.Add(areaAsocia.GetComponent<ClickDetect>());
        clicker.Add(areaMoto.GetComponent<ClickDetect>());
    }

    void Update()
    {
        if (altern)
        {
            foreach (ClickDetect area in clicker)
            {
                int rand = Random.Range(0, 20);
                if (rand == 1)
                    area.alternActive();
            }
            // Controla el tiempo entre actualizaciones
            float waitTime = 2.0f;
            float elapsedTime = 0.0f;
            while (elapsedTime < waitTime)
            {
                elapsedTime += Time.deltaTime;
            }
        }
    }

    public void AlternMode() {
        altern = !altern;
    }
}