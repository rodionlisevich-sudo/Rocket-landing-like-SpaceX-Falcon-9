using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;
        
        if (keyboard.rKey.wasPressedThisFrame)
        {
            RestartGame();
        }
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}