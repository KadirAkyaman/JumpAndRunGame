using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timeRemainingText;
    public float timeRemaining;
    void Start()
    {
        StartCoroutine(Countdown(timeRemaining));
    }


    public IEnumerator Countdown(float timeRemaining)
    {

        while (timeRemaining > 0)
        {
            timeRemainingText.text = Mathf.Round(timeRemaining).ToString();
            //remainingTime.text = Mathf.Round(timeRemaining).ToString();

            yield return new WaitForSeconds(1.0f);
            timeRemaining--;
        }
        SceneManager.LoadScene("WinScene");
    }
}
