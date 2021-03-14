using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;

    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        changeGuessLabel();
        max = max + 1;
    }

    private void changeGuessLabel()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        changeGuessLabel();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        changeGuessLabel();
    }
}
