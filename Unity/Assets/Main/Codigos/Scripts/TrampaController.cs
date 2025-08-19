using UnityEngine;
using UnityEngine.SceneManagement;
public class TrampaController : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
            SceneManager.LoadScene("Condicionales");
        }
    }

  


}
