using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
        public float speed = 2f;
            float initialYValue;
    // Start is called before the first frame update
    void Start()
    {
                initialYValue = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-speed * Time.deltaTime,0);
        speed += 0.5f * Time.deltaTime;

    }
    public void MmoveBoxToRamdomPosition()
    {
        Vector3 newPosition = transform.position;
        int ramdomX = 0;
        ramdomX = Random.Range(0, 3);
        if(ramdomX == 0)
        {
            newPosition.x = -2;
        }
        else if(ramdomX == 1)
        {
            newPosition.x = 0;
        }
        else
        {
            newPosition.x = 2;
        }
        newPosition.y = initialYValue;

        transform.position = newPosition;
    }
}
