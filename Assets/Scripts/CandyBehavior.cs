using UnityEngine;

public class CandyBehavior : MonoBehaviour
{
    // This method is executed when the object collides with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object it collided with is a collectable
        if (collision.gameObject.CompareTag("Collectable"))
        {
            NewMonoBehaviourScript.Instance.AddScore(100);
            Destroy(collision.gameObject); // Destroy the collectable
        }

        // Check if the object it collided with is the ground (not a Trigger)
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Get the X position of the Candy_0 when it falls
            float candyPositionX = transform.position.x;

            // Define the ground boundaries (adjust these values based on your scene)
            float minX = -3f; // Adjust these values based on your scene
            float maxX = 3f;  // Adjust these values based on your scene

            // Calculate the size of each division
            float divisionSize = (maxX - minX) / 6f;

            int points = 0;

            // Assign points depending on the X position
            if (candyPositionX >= minX && candyPositionX < minX + divisionSize)
            {
                points = 0; // Zone 1
            }
            else if (candyPositionX >= minX + divisionSize && candyPositionX < minX + 2 * divisionSize)
            {
                points = 15; // Zone 2
            }
            else if (candyPositionX >= minX + 2 * divisionSize && candyPositionX < minX + 3 * divisionSize)
            {
                points = 20; // Zone 3
            }
            else if (candyPositionX >= minX + 3 * divisionSize && candyPositionX < minX + 4 * divisionSize)
            {
                points = 20; // Zone 4
            }
            else if (candyPositionX >= minX + 4 * divisionSize && candyPositionX < minX + 5 * divisionSize)
            {
                points = 15; // Zone 5
            }
            else if (candyPositionX >= minX + 5 * divisionSize && candyPositionX <= maxX)
            {
                points = 0; // Zone 6
            }

            // Update the score
            NewMonoBehaviourScript.Instance.AddScore(points);

            // Destroy the Candy_0 when it touches the ground
            Destroy(gameObject);
        }
    }
}

