using UnityEngine;

public class UpdateUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.GetComponent<PlayerController>())
        {
            if (gameObject.CompareTag("Coin"))
            {
                Destroy(this.gameObject);
                //other.gameObject.GetComponent<PlayerController>().num_coins++;
            }
            else if (gameObject.CompareTag("Enemy"))
            {
                GameManagerClase.instancia.DeleteLife();
            }

        }

    }

    private void OnDestroy()
    {
        GameManagerClase.instancia.AddMoneda();
    }
}