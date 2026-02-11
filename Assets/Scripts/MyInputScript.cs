using UnityEngine;

public class MyInputScript : MonoBehaviour
{
    [SerializeField] private float speed = 0.2f;
    private void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //     Debug.Log("He pulsado la letra W");
        //     transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // } 

        // if (Input.GetKey(KeyCode.S))
        // {
        //     transform.Translate(Vector3.back * speed * Time.deltaTime);
        // } 
        
        // if (Input.GetKey(KeyCode.A))
        // {
        //     transform.Translate(Vector3.left * speed * Time.deltaTime);
        // } 

        // if (Input.GetKey(KeyCode.D))
        // {
        //     transform.Translate(Vector3.right * speed * Time.deltaTime);
        // } 

        // if (Input.GetKey(KeyCode.Space))
        // {
        //     transform.Translate(Vector3.up * speed * Time.deltaTime);
        // } 

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v).normalized;

        transform.Translate(movement * speed * Time.deltaTime);

    }
    
}