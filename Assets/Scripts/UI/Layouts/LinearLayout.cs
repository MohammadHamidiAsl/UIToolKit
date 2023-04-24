using UnityEngine;
using UnityEngine.UI;

public class LinearLayout : MonoBehaviour
{
    // This script assumes that the RectTransform and LayoutGroup components
    // have already been added to the GameObject.

    // Add a child element to the LinearLayout.
    public void AddChild(GameObject child)
    {
        child.transform.SetParent(transform);
    }

    // Remove a child element from the LinearLayout.
    public void RemoveChild(GameObject child)
    {
        child.transform.SetParent(null);
    }
}