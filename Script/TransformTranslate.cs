using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTranslate : MonoBehaviour
{
    //Mueve objetos en base a una distancia y direccion.

    public float velocidad;
    private Rigidbody2D rb2d;


    private void Start()
    {
        rb2d = GetComponent < Rigidbody2D > ();
    }

    private void Update()
    {
        /*
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(inputX,inputY, 0);

        rb2d.transform.Translate(movimiento * velocidad * Time.deltaTime);
        */

        rb2d.transform.Translate(Vector3.right * velocidad * Time.deltaTime);

    
    }

}
