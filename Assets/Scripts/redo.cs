using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class redo : MonoBehaviour
{
    public Gameoverscreen GameOverScreen;

    void Update()
    {
     if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            RetryButton();
        }
    }
    public void RetryButton()
    {
        SceneManager.LoadScene(0);
        GameOverScreen.gameObject.SetActive(false);
    }
    
    
}
