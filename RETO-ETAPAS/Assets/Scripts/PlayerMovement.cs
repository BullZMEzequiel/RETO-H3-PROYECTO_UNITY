using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Referencias a componentes
    public CharacterController controller;
    public Transform cam; // Arrastra la "Main Camera" aquí

    // Parámetros de movimiento
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;

    void Update()
    {
        // 1. Capturar el movimiento del teclado (AWSD / Flechas)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // 2. Si hay movimiento...
        if (direction.magnitude >= 0.1f)
        {
            // Calcular el ángulo de rotación mirando hacia donde apunta la cámara
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            
            // Rotar el personaje
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            // Mover el personaje en la dirección de la rotación
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }
}