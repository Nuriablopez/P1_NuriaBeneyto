using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    // 1. La variable se declara AQU� (fuera de los m�todos) para que todo el script la vea
    private Rigidbody rb;

    void Start()
    {
        // 2. Buscamos el componente al empezar
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 3. Activamos la gravedad
            rb.useGravity = true;

            // CONSEJO: Si tu plataforma es "Kinematic", a�ade esta l�nea 
            // para que la gravedad realmente le afecte:
            rb.isKinematic = false;
        }
    }
}
