using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebViewManager : MonoBehaviour
{
    [SerializeField] private InputField urlInputField;
    [SerializeField] private WebViewObject webViewObject;

    public void LoadWebPage()
    {
        if (!string.IsNullOrEmpty(urlInputField.text))
        {
            string url = urlInputField.text;
            webViewObject.LoadURL(url);
        }
    }

    public void CloseWebView()
    {
        webViewObject.SetVisibility(false);
    }
}