using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SnackbarUI : MonoBehaviour
{
    public float fadeDuration = 0.5f;
    public float visibleDuration = 2f;
    public AnimationCurve fadeCurve;

    private Text _textComponent;
    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        _textComponent = GetComponentInChildren<Text>();
        _canvasGroup = GetComponent<CanvasGroup>();

        // Hide the snackbar panel by default
        _canvasGroup.alpha = 0f;
        gameObject.SetActive(false);
    }

    public void ShowSnackbar(string message)
    {
        // Stop any running coroutines before starting a new one
        StopAllCoroutines();

        // Set the snackbar message
        _textComponent.text = message;

        // Enable the snackbar panel
        gameObject.SetActive(true);

        // Start the fade-in coroutine
        StartCoroutine(FadeCoroutine(0f, 1f, fadeDuration, fadeCurve, () =>
        {
            // Start the visible duration coroutine after the fade-in
            StartCoroutine(VisibleCoroutine(visibleDuration, () =>
            {
                // Start the fade-out coroutine after the visible duration
                StartCoroutine(FadeCoroutine(1f, 0f, fadeDuration, fadeCurve, () =>
                {
                    // Disable the snackbar panel after the fade-out
                    gameObject.SetActive(false);
                }));
            }));
        }));
    }

    private IEnumerator FadeCoroutine(float startValue, float endValue, float duration, AnimationCurve curve, System.Action onComplete = null)
    {
        float timer = 0f;

        while (timer < duration)
        {
            float t = curve.Evaluate(timer / duration);
            _canvasGroup.alpha = Mathf.Lerp(startValue, endValue, t);
            timer += Time.deltaTime;
            yield return null;
        }

        _canvasGroup.alpha = endValue;

        onComplete?.Invoke();
    }

    private IEnumerator VisibleCoroutine(float duration, System.Action onComplete = null)
    {
        yield return new WaitForSeconds(duration);
        onComplete?.Invoke();
    }
}
