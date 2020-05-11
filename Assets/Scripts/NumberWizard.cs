using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {


    private int max;
    private int min;
    private int guess;
    private int maxGuessesAllowed = 5;
    public Text text;

    // Use this for initialization
    public void Start()
    {
        initializeGame();
    }

    private void initializeGame()
    {
        this.max = 100;
        this.min = 1;
        nextGuess();
   }

    private void nextGuess()
    {
        guess = Random.Range(min, max+1); ;
        text.text = guess.ToString();
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            //Application.LoadLevel("Win");
            SceneManager.LoadScene("Win");
        }
    }

    public void guessHigher()
    {
        min = guess;
        nextGuess();
    }

    public void guessLower()
    {
        max = guess;
        nextGuess();
    }

}
