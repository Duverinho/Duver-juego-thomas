using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntaje : MonoBehaviour
{
    private float puntos;

    private TextMeshProUGUI TextMesh;

    private void Start()
    {
        TextMesh = GetComponent<TextMeshProUGUI>();

    }

    private void Update()
    {
       
        TextMesh.text = puntos.ToString();

    }
    public void SumarPuntos(float puntosentrada)
    {
        puntos += puntosentrada;

    }
}
