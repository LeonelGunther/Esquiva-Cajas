using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColition : MonoBehaviour
{
    public VelocidadUI caca;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
           Destroy(gameObject);
           caca.vivo = false;
        }
    }
}
