using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class VelocidadUI : MonoBehaviour
{
    public TextMeshProUGUI TextoTiempo;
    float tiempo = 0f;
    public bool vivo = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vivo == true){
        tiempo += Time.deltaTime;
        TextoTiempo.text= "Tiempo:  " + tiempo.ToString("F2");
        }
    }
}
