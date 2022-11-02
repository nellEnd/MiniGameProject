using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countingCoinsScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreUI;

    private int _score = 0;

    public void IncreasePoint()
    {
        _score = _score + 1;

        StartCoroutine(ShowScoreAndHideIt(2));
    }

    IEnumerator ShowScoreAndHideIt(int secondsToBeShown)
    {
        scoreUI.gameObject.SetActive(true);

        scoreUI.text = "COLLECTED COINS : " + _score.ToString();

        yield return new WaitForSeconds(secondsToBeShown);

        scoreUI.gameObject.SetActive(false);
    }
}
