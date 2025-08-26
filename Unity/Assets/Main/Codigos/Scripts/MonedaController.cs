using UnityEngine;

public class MonedaController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("El jugador me toco");
            gameManager.SumarUnPunto(1);
            Destroy(this.gameObject);
        }
    }
}
