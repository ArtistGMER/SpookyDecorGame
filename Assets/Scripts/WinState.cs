using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class WinState : MonoBehaviour
{
    public Gameoverscreen GameOverScreen;
    public FurnatureTracker FT;
    void Start()
    {
        if (GameOverScreen != null)
        {
            GameOverScreen.gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        FurnatureTracker tracker = GetComponent<FurnatureTracker>();
        if (tracker != null && FT.ItemTracker != null)
        {
            if (tracker.ItemTracker.Count == 1)
            {
                Debug.Log("WIN");
                WinStateTrigger();
                //GameOverScreen.SetUp(FT.score);
                //GameOverScreen.gameObject.SetActive(true);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void WinStateTrigger()
    {
        GameOverScreen.SetUp(FT.score);
        GameOverScreen.gameObject.SetActive(true);
    }
}
