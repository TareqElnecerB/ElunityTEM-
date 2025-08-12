using UnityEngine;
using TMPro;


public class TallerVariables : MonoBehaviour
{
    //Declarar las variables privadas y serializadas
    // = aignar un valor ""==""comparar"
    [SerializeField]
    private string _nombre;
    [SerializeField]
    private int _vida = 10;
    [SerializeField]
    private int _tiempo = 60;
    [SerializeField]
    private int _puntos = 50;
    [SerializeField]
    private bool _estaVivo = true;
    [SerializeField]
    private TMP_Text _mensaje;
    [SerializeField]
    private TMP_Text _mensajeVida;
    [SerializeField]
    private TMP_Text _mensajePuntos;
    [SerializeField]
    private TMP_Text _mensajetiempo;
    [SerializeField]
    private TMP_Text _mensajeEstado;
    [SerializeField]
    void Start()
    {
        _mensaje.text = "Nombre: " + _nombre;
        _mensajeVida.text = "Vida:" + -_vida;
        _mensajePuntos.text = "Puntos que tienes : " + _puntos;
        _mensajetiempo.text = "Tiempo : " + _tiempo;
        _mensajeEstado.text = "Estado de vida" + _estaVivo;
    }

    
    void Update()
    {
        if (_nombre=="Diego")
        {
            Debug.Log("Hablalo diegiño");
        }
        else
        {
            Debug.Log("hola señor");
        }
    }
}
