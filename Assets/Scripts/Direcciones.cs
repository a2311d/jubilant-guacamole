using UnityEngine;

public class Direcciones : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float salto;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {

        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.right * desplX * Time.deltaTime * force);
        rb.AddForce(Vector3.forward * desplY * Time.deltaTime * force);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * salto);
        }
    }
}
