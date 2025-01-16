# 🚀 Game Play
![Recording+2025-01-16+at+01 06 02](https://github.com/user-attachments/assets/55817635-f5cd-4b12-b312-9c380ee68d0a)


# Authors
- [@Narda05](https://github.com/Narda05)

## 🚀 Quick Start

1. Clone the repository
2. Open in Unity 6
3. Load the main scene
4. Hit play and start dropping candies!

## 🎮 Controls

```
Movement:
W/↑ - Move Up
S/↓ - Move Down
A/← - Move Left
D/→ - Move Right

Action:
SPACE - Drop Candy
```

## 🏆 Scoring System

```
Base Points:
- Center Zones (3,4): 20 points
- Mid Zones (2,5): 15 points
- Edge Zones (1,6): 0 points

Bonuses:
- Collectables: +100 points
```
## 🎨 Visual Design

Our game features a vibrant candy-themed design with:

- Sweet shop background with donuts and pastries
- Pink and blue donut obstacles arranged in a grid pattern
- Clean, minimalist UI with score display
- Candy-themed scoring zones at the bottom
- Pastel color palette throughout

![Captura de pantalla 2025-01-16 005145](https://github.com/user-attachments/assets/662f053e-6822-4a2a-82c3-90dbcebc926f)

## 🔧 How It All Works

### Core Scripts Overview

#### 1. Game Manager (NewMonoBehaviourScript.cs)
```csharp
public class NewMonoBehaviourScript : MonoBehaviour
{
    private static NewMonoBehaviourScript instance = null;  
    public static NewMonoBehaviourScript Instance
    {
        get { return instance; }
    }

    [SerializeField]
    private TMP_Text scoreText = null;
    [SerializeField]
    private GameObject candyPrefab = null;
    [SerializeField]
    private PlayerController playerController = null;

    private int score = 0;

    // ... rest of the implementation
}
```
This script manages:
- Score tracking
- Candy spawning
- Game state
- UI updates

#### 2. Player Controller (PlayerController.cs)
```csharp
public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 1.0f;
    private Vector3 moveDistance = Vector3.zero;
    
    [SerializeField]
    private float minY = 0f;
    [SerializeField]
    private float maxY = 5f;

    // ... rest of the implementation
}
```
Handles:
- Candy launcher movement
- Position constraints
- Input processing

#### 3. Candy Behavior (CandyBehavior.cs)
```csharp
public class CandyBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            NewMonoBehaviourScript.Instance.AddScore(100);
            Destroy(collision.gameObject);
        }
        // ... rest of the implementation
    }
}
```
Controls:
- Candy physics
- Collision detection
- Scoring logic

## 🎭 Behind the Scenes

### Physics System
- Custom-tuned gravity settings
- Precise collision detection
- Optimized performance for multiple candies

### Scoring Zones
The game features six scoring zones at the bottom:
```
Zone Layout:
╔════════════════════╗
║   1   2   3   4   5   6   ║
║   0  15  20  20  15   0   ║
╚════════════════════╝
```

### Obstacle System
- Static donut pins arranged in a grid
- Pink and blue alternating pattern
- Carefully placed to create interesting ball paths

## 💡 Pro Tips

1. **Timing is Everything**
   - Wait for moving obstacles to align
   - Watch for patterns in paddle rotations

2. **Score Maximization**
   - Aim for center zones (3 & 4) for max points
   - Collect power-ups during candy descent
   - Use bounces to your advantage



## 🔧 Technical Requirements

### Minimum Specs
```
🎮 Unity Version:
- Unity 6 
- Universal Render Pipeline
```




### Resolution Support
- Primary: 768x1024 (Portrait)
- Aspect Ratio: 3:4


