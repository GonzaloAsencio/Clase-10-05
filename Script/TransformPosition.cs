using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    //Mueve el objeto a una posicion fija.


    public float x = 0;
    public float y = 0;
    public float z = 0;

    float speed = 5f;

    void Start()
    {
        transform.position = new Vector3(x ,y,z);
    }


    private void Update()
    {
       /* float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(inputX, inputY, 0);

        transform.position += (movimiento * Time.deltaTime * speed);*/
    }


}
