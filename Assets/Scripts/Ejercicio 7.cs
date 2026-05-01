using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    [SerializeField] float torque;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * torque * turn);

    }
}
