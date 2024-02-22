using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static void Restart()
    {
        int index = SceneMnager.GetActiveScene().buildindex;
        SceneManager.LoadScene(index);
    }
    public static void Defeat()
    {
        score = 0;
    }
    public static List<Square> squares;
    void Awake()
    {
        squares = new List<Square>();
    }
    public static int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (squares.Count == 0)
        {
            Victory();
        }
    }
    public static void Defeat()
    {
        UI.ShowDefeatPanel();
        score = 0;
    }
    public static void Victory()
    {
        UI.ShowVictoryPanel;
    }
}
