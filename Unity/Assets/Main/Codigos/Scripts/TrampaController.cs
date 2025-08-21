using UnityEngine;
using UnityEngine.SceneManagement;
public class TrampaController : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Time.timeScale = 1f;
            SceneManager.LoadScene("Condicionales");
        }
    }

  


}
