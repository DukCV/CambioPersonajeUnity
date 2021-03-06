using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Listas : ScriptableObject
{
    public Ficha[] personajes;

    public int contadorDePersonajes
    {
        get
        {
            return personajes.Length;
        }
    }

    public Ficha ObtenerPersonaje(int index)
    {
        return personajes[index];
    }
}
