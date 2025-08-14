using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;
    [SerializeField]
    private Vector2 v2;
    [SerializeField]
    private float fuerza = 10;
    private void Awake() // prepara todo antes del start
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            rb2d.AddForce(v2 * fuerza);
            
        }
        else
        {
            print("No imprimi la tecla espacio");
        }
    }
}
