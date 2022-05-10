using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastJump : MonoBehaviour
{
    public float Distancia_Raycast = 0.5f;
    public LayerMask suelo;
    public bool Esta_en_el_suelo;

    private void Update()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, Distancia_Raycast,suelo))
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
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector2.down * Distancia_Raycast);
       
    }
}


