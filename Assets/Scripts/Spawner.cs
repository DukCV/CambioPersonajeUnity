using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Listas lista_Personajes;

    private int contadorDePersonajes;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("contadorDePersonajes"))
        {
            contadorDePersonajes = 0;
        }
        else
        {
            Cargar();
        }

        InvocarPersonaje(contadorDePersonajes);

    }

    private void InvocarPersonaje(int contadorDePersonajes)
    {
        Ficha personaje = lista_Personajes.ObtenerPersonaje(contadorDePersonajes);
        Instantiate(personaje.objeto_Jugador);
    }

    private void Cargar()
    {
        contadorDePersonajes = PlayerPrefs.GetInt("contadorDePersonajes");
    }
}
