using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TabButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public TabGroup tabGroup;
    public Image background;
    public int tabIndex;
    public Text label;
    public event System.Action<int> OnTabSelected=null;
    [SerializeField] private Color selectedColor;
    [SerializeField] private Color deselectedColor;

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this.tabIndex);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        background.color = tabGroup.tabHoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(tabGroup.selectedTab != this)
            background.color = tabGroup.tabIdleColor;
    }

    void Start()
    {
        label = GetComponentInChildren<Text>();
        tabGroup.Subscribe(this);
    }

    public void SetLabel(string text)
    {
        label.text = text;
    }

    public void Select()
    {
        // Change the color of the tab button to indicate that it is selected
        GetComponent<Image>().color = selectedColor;

        // Trigger some behavior in your UI based on which tab button is selected
        if (tabGroup != null)
        {
            tabGroup.OnTabSelected(this.tabIndex);
        }
    }

    public void Deselect()
    {
        // Change the color of the tab button to indicate that it is deselected
        GetComponent<Image>().color = deselectedColor;
    }

    protected virtual void OnOnTabSelected(int index)
    {
        OnTabSelected?.Invoke(index);
    }
}