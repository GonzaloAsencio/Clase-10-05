using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addforce : MonoBehaviour
{
    //Empuja Objetos a una direccion e interactua con la gravedad

    public float velocidad;

    private Rigidbody2D rb2d;


    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(inputX,inputY, 0);

     

        rb2d.AddForce(Vector2.right * velocidad * inputX ,ForceMode2D.Force);


        if (Input.GetKey(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * velocidad * Time.deltaTime, ForceMode2D.Impulse);
        }


        /*ForceMode.Force - Esto acelerará en la dirección del objeto y también teniendo en cuenta la masa del mismo.
          ForceMode.Acceleration - Esto acelerará en la dirección del objeto pero ignorará su masa.
          ForceMode.Impulse - Agrega una fuerza instantánea al objeto cancelando cualquier fuerza de aceleración, esto también tiene en cuenta la masa del mismo objeto.
          ForceMode.VelocityChange - Agrega una fuerza de instancia al objeto que cancela cualquier fuerza de aceleración, esto ignorará la masa del mismo objecto.
        */
    }
}