using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public void OnClickRestart()
    {
        Player.Restart();
    }
    static UI singleton;
    public GameObject panel;
    public Text panelScoreText;
    public Text defeatText;
    public TextAlignment victoryText;
    public TextAlignment scoreText;
    void Awake()
    {
        singleton = this;
    }
    public static void ShowVictoryPanel()
    {
        singleton.panel.SetActive(true);
        singleton.victoryText.gameObject.SetActive(true);
        singleton.panelScoreText.text = Player.score.ToString();
    }
    public static void ShowDefeatPanel()
    {
        singleton.panel.SetActive(true);
        singleton.defeatText.gameObject.SetActive(true);
        singleton.panelScoreText.text = Player.score.ToString();ss
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.Text = Player.score.ToString();
    }
}
