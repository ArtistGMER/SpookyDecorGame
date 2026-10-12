using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gameoverscreen : MonoBehaviour
{
    public TextMeshProUGUI FinalScoreText;
    public FurnatureTracker score;
    public void SetUp(float score)
    {
        gameObject.SetActive(true);
        FinalScoreText.text = score + "\n" + "POINTS";
    }
    void Start()
    {
      
    }

    void Update()
    {
        
    }


}
