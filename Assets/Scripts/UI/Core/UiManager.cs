using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    private static UiManager _instance;

    public static UiManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("The UiManager is NULL.");
            }

            return _instance;
        }
    }

    public GameObject[] screens;

    private Stack<GameObject> _screenStack = new Stack<GameObject>();

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        ShowScreen(screens[0].name);
    }

    public void ShowScreen(string screenName)
    {
        foreach (GameObject screen in screens)
        {
            if (screen.name == screenName)
            {
                if (_screenStack.Count > 0)
                {
                    _screenStack.Peek().SetActive(false);
                }

                screen.SetActive(true);
                _screenStack.Push(screen);

                break;
            }
        }
    }

    public void GoBack()
    {
        if (_screenStack.Count > 1)
        {
            _screenStack.Pop().SetActive(false);
            _screenStack.Peek().SetActive(true);
        }
    }

    public void CloseCurrentScreen()
    {
        _screenStack.Pop().SetActive(false);

        if (_screenStack.Count > 0)
        {
            _screenStack.Peek().SetActive(true);
        }
    }

    public void CloseAllScreens()
    {
        while (_screenStack.Count > 0)
        {
            _screenStack.Pop().SetActive(false);
        }
    }

    public void OpenUrl(string url)
    {
        Application.OpenURL(url);
    }
}