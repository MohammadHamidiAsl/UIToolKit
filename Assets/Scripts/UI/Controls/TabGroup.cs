using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public List<GameObject> tabPages;
    public Object selectedTab;
    public Color tabHoverColor;
    public Color tabIdleColor;

    public void Subscribe(TabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabSelected(int index)
    {
        for (int i = 0; i < tabButtons.Count; i++)
        {
            if (tabButtons[i].tabIndex ==index )
            {
                tabButtons[i].Select();
                tabPages[i].SetActive(true);
            }
            else
            {
                tabButtons[i].Deselect();
                tabPages[i].SetActive(false);
            }
        }
    }
}