using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToastUIController : MonoBehaviour
{
    public void ShowToast(string message)
    {
        // Set the text of the Text component to the message
        GetComponentInChildren<Text>().text = message;
        
        // Start a coroutine to hide the toast after a certain amount of time
        StartCoroutine(HideToast());
    }

    private IEnumerator HideToast()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2f);
        
        // Disable the GameObject to hide the toast
        gameObject.SetActive(false);
    }
}