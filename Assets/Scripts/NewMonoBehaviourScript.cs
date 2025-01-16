using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
   private static NewMonoBehaviourScript instance = null;  
    public static NewMonoBehaviourScript Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField]
    private TMP_Text scoreText = null;

    [SerializeField]
    private GameObject candyPrefab = null;

    //Player Script
    [SerializeField]
    private PlayerController playerController = null;

    private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(instance != null) 
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            AddScore(0);

        }
    }
 private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCandy();
        }
    }
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score.ToString();
        
    }

    public int GetScore()
    {
        return score;
    }


    public void SpawnCandy()
    {
        // Verificar si el PlayerController está asignado
        if (playerController == null)
        {
            Debug.LogError("PlayerController no está asignado en el Game Manager.");
            return;
        }

        // Generar el prefab en la posición del jugador
        Vector3 spawnPosition = playerController.GetPlayerPosition();
        Instantiate(candyPrefab, spawnPosition, Quaternion.identity);
    }

}
