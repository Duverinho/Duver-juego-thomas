using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class movimientolaser : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private Transform controladorlaser;
    [SerializeField] private float distancia;
    [SerializeField] private bool movimientoderecha;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        RaycastHit2D informacionsuelo = Physics2D.Raycast(controladorlaser.position, Vector2.down, distancia);

        rb.velocity = new Vector2(velocidad, rb.velocity.y);

        if (informacionsuelo == false)
        {
            girar();

        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(controladorlaser.transform.position, controladorlaser.transform.position + Vector3.down * distancia);
    }

    private void girar()
    {
        movimientoderecha = !movimientoderecha;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        velocidad *= -1;
    }
}

