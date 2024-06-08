using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frutacontroller : MonoBehaviour
{
    [SerializeField] private GameObject efecto;

    [SerializeField] private float cantidadpuntos;

    [SerializeField] private puntaje puntaje;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.CompareTag("Player"))
        {
            puntaje.SumarPuntos(cantidadpuntos);
            if (efecto != null)
            {
                Instantiate(efecto, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);

        }
    }


}
