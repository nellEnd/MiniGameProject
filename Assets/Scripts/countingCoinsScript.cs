using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountingCoinsScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreUI;

    [SerializeField]
    private Image coinUI;

    private int _score = 0;

    public void IncreasePoint()
    {
        _score = _score + 1;

        StartCoroutine(ShowScoreAndHideIt(2));
    }

    IEnumerator ShowScoreAndHideIt(int secondsToBeShown)
    {
        scoreUI.gameObject.SetActive(true);
        coinUI.gameObject.SetActive(true);

        scoreUI.text = _score.ToString();

        yield return new WaitForSeconds(secondsToBeShown);

        scoreUI.gameObject.SetActive(false);
        coinUI.gameObject.SetActive(false);
    }
}
