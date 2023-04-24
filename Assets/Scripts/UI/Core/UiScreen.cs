using UnityEngine;
using UnityEngine.UI;

public class UIScreen : MonoBehaviour
{
    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

    public virtual void SetTitle(string title)
    {
        Text titleText = transform.Find("Title").GetComponent<Text>();
        titleText.text = title;
    }

    public virtual InputField AddInputField(string label, bool isPassword = false)
    {
        GameObject inputFieldPrefab = Resources.Load<GameObject>("Prefabs/UI/InputField");
        GameObject inputFieldObject = Instantiate(inputFieldPrefab, transform);
        Text labelText = inputFieldObject.transform.Find("Label").GetComponent<Text>();
        labelText.text = label;
        InputField inputField = inputFieldObject.GetComponent<InputField>();
        inputField.contentType = isPassword ? InputField.ContentType.Password : InputField.ContentType.Standard;
        return inputField;
    }

    public virtual Button AddButton(string label)
    {
        GameObject buttonPrefab = Resources.Load<GameObject>("Prefabs/UI/Button");
        GameObject buttonObject = Instantiate(buttonPrefab, transform);
        Text buttonText = buttonObject.transform.Find("Label").GetComponent<Text>();
        buttonText.text = label;
        return buttonObject.GetComponent<Button>();
    }
}