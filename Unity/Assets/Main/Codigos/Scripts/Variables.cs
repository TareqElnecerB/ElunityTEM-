using System;
using UnityEngine;

public class Variables : MonoBehaviour
{
    [SerializeField]
   private int vida = 1;
    [SerializeField]
   private int puntaje = 200;
    [SerializeField]    
   private int nivel = 29;

   public string nombre = "Roberto";
    
    private float tiempo = 6.5f;
    [SerializeField]
    private bool isAlive = true;
    [SerializeField]
    public GameObject camera;
    void Start()
    {
        Debug.Log("hola mundo la k el trap de medallo");
    }

    // Update is called once per frame
    void Update()
    {
        print("Hola mundo");
    }
}
