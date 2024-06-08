using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class trampatecho : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float distancialinea;
    public LayerMask capadejugador;
    public bool estasubiendo = false;
    public float velocidadsubida;


    private void Update()
    {
        RaycastHit2D infojugador = Physics2D.Raycast(transform.position, Vector3.down, distancialinea, capadejugador);

        if (infojugador && !estasubiendo)
        {
            rb2D.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        }
        if (estasubiendo)
        {
            transform.Translate(Time.deltaTime * velocidadsubida * Vector3.up);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("piso"))
        {
            rb2D.constraints = RigidbodyConstraints2D.FreezeAll;

            if (estasubiendo)
            {
                estasubiendo = false;
            }
            else
            {
                estasubiendo = true;

            }
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * distancialinea);
    }
}
