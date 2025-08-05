using UnityEngine;
using TMPro;


public class TallerVariables : MonoBehaviour
{
    //Declarar las variables privadas y serializadas
    [SerializeField]
    private string nombre;
    [SerializeField]
    private int vida = 10;
    [SerializeField]
    private int tiempo = 60;
    [SerializeField]
    private int puntos = 50;
    [SerializeField]
    private bool estaVivo = true;
    [SerializeField]
    private TMP_Text mensaje;
    [SerializeField]
    private TMP_Text mensajeVida;
    [SerializeField]
    private TMP_Text mensajePuntos;
    [SerializeField]
    private TMP_Text mensajetiempo;
    [SerializeField]
    private TMP_Text mensajeEstado;
    [SerializeField]
    void Start()
    {
        mensaje.text = "Hola jugador " + nombre;
        mensajeVida.text = "Tu vida es: " + vida;
        mensajePuntos.text = "Puntos que tienes : " + puntos;
        mensajetiempo.text = "Tiempo : " + tiempo;
        mensajeEstado.text = "Estado de vida" + estaVivo;
            
    }

    
    void Update()
    {
        
    }
}
