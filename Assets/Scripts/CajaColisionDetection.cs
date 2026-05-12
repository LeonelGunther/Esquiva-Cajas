using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColisionDetection : MonoBehaviour
{
    public CajaMovement cajaMovementscript;

    void Start()
    {
        cajaMovementscript = GetComponent<CajaMovement>();

    }
     void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Piso"))
        {
           cajaMovementscript.MmoveBoxToRamdomPosition();
         }
    }
}
