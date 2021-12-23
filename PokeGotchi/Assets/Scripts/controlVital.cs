using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlVital : MonoBehaviour
{

    public int comida;
    public double intervalo, timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = intervalo;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0 && comida >= 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {

            if(comida >= 0)
            {
                comida--;
                timer = intervalo;
            }
            else
            {
                Debug.Log("Se murio");
            }
        }

        Debug.Log("Timer" + timer);
        Debug.Log("Comida" + comida);
    }
}
