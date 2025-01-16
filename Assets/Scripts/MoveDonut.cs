using UnityEngine;

public class MoveDonut : MonoBehaviour
{
    [SerializeField]
    private float cloudSpeed = 1f;
    [SerializeField]
    private float changeDirectionTime = 2f;
    private float timer = 0f;
    private int direction = 1;

    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal basado en la dirección
        transform.Translate(direction * cloudSpeed * Time.deltaTime, 0, 0);

        // Incrementar el temporizador
        timer += Time.deltaTime;

        // Cambiar de dirección al alcanzar el tiempo especificado
        if (timer >= changeDirectionTime)
        {
            direction *= -1; // Cambiar dirección
            timer = 0f; // Reiniciar el temporizador
        }
    }
}
