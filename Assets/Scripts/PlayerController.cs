using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 1.0f;
    private Vector3 moveDistance = Vector3.zero;

    // Movement limits on the Y axis (you can adjust these as needed)
    [SerializeField]
    private float minY = 0f;  // The minimum (down) point where the generator can be
    [SerializeField]
    private float maxY = 5f;  // The maximum (up) point where the generator can be

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveDistance.y = moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDistance.y = -moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveDistance.x = -moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDistance.x = moveSpeed * Time.deltaTime;
        }

        // Update the position, but make sure we don't go beyond the limits on the Y axis
        Vector3 newPosition = transform.position + moveDistance;

        // Restrict the position on the Y axis so the generator doesn't move out of the allowed zone
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // Assign the new position of the generator
        transform.position = newPosition;
    }
    public Vector3 GetPlayerPosition()
    {
        return transform.position;
    }
}


