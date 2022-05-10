using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapJump : MonoBehaviour
{
    public float Distancia_Overlap = 0.5f;
    public Transform posicion;
    public LayerMask suelo;
    public bool Esta_en_el_suelo;

    private void Update()
    {
        if (Physics2D.OverlapBox(posicion.position,transform.position, Distancia_Overlap, suelo))
        {
            Esta_en_el_suelo = true;


        }
        else
        {
            Esta_en_el_suelo = false;
            //Logica de Salto
        }


    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(posicion.position, transform.position * Distancia_Overlap);

    }
}
