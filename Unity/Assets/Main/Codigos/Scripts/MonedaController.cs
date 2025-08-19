using UnityEngine;

public class MonedaController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("El jugador me toco");
            Destroy(this.gameObject);
        }
    }
}
