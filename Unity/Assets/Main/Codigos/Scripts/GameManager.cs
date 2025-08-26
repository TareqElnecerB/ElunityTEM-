using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int _puntos;
    [SerializeField]
    private int _vida;
    public void SumarUnPunto(int cantidad)
    {
        _puntos += cantidad;
    }

   public void RestarPuntosDeVida(int cantidad)
    {
       
        if( _vida <= 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            _vida -= cantidad;
        }
    }
    
}
