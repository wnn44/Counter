using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private float _delay = 0.5f;

    protected int CurrentTimer = 0;

    private void Start()
    {
        _text.text = CurrentTimer.ToString();
    }

    private IEnumerator Countdown(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (true)
        {
            DisplayCountDowd(CurrentTimer);

            yield return wait;

            CurrentTimer++;
        }
    }

    private void DisplayCountDowd(int count)
    {
        _text.text = count.ToString();
    }

    public void PauseCount()
    {
        StopAllCoroutines();
    }

    public void ResumeCount()
    {
        StartCoroutine(Countdown(_delay));
    }
}
