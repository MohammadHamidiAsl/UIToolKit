using UnityEngine;
using UnityEngine.UI;

public class SwitchUIHandler : MonoBehaviour
{
    Toggle toggle;

    void Awake()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    void OnDestroy()
    {
        toggle.onValueChanged.RemoveListener(OnToggleValueChanged);
    }

    void OnToggleValueChanged(bool value)
    {
        Debug.Log("Switch toggled: " + value);
    }
}