using System;
using UnityEngine;
using TMPro;

public class Variables : MonoBehaviour
{
    [Header("variables c#")]
    [SerializeField]
    private int vida = 1;
    [SerializeField]
    private int puntaje = 200;
    [SerializeField]
    private int nivel = 29;
    [SerializeField]
    private float tiempo = 60.5f;
    [SerializeField]
    public string nombre = "Alejo";
    [SerializeField]
    private bool isAlive = true;

    [Header("Variables unity")]
    [SerializeField]
    private TMP_Text mensaje;
    

    
    void Start()
    {
        mensaje.text = "Hola " + nombre + ", como estas?"; 
    }

    // Update is called once per frame
    void Update()
    {
        print("Hola mundo");
    }
}
