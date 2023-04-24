using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabView : MonoBehaviour
{
    [SerializeField] private List<string> tabLabels;
    [SerializeField] private List<GameObject> tabContents;
    [SerializeField] private GameObject tabButtonPrefab;
    [SerializeField] private Transform tabButtonParent;
    [SerializeField] private Color selectedTabColor;
    [SerializeField] private Color unselectedTabColor;

    private List<TabButton> tabButtons;
    private int selectedIndex = -1;

    private void Start()
    {
        if (tabLabels.Count != tabContents.Count)
        {
            Debug.LogError("Tab labels count must match tab contents count.");
            return;
        }

        tabButtons = new List<TabButton>();

        for (int i = 0; i < tabLabels.Count; i++)
        {
            GameObject tabButtonObj = Instantiate(tabButtonPrefab, tabButtonParent);
            TabButton tabButton = tabButtonObj.GetComponent<TabButton>();
            tabButton.SetLabel(tabLabels[i]);
            tabButton.OnTabSelected += i1 => SelectTab(i); 

            tabButtons.Add(tabButton);

            if (i == 0)
            {
                SelectTab(i);
            }
        }
    }

    private void SelectTab(int index)
    {
        if (selectedIndex == index)
        {
            return;
        }

        if (selectedIndex >= 0)
        {
            tabButtons[selectedIndex].Select();
            tabContents[selectedIndex].SetActive(false);
        }

        selectedIndex = index;

        tabButtons[selectedIndex].Select();
        tabContents[selectedIndex].SetActive(true);

        for (int i = 0; i < tabButtons.Count; i++)
        {
            if (i == selectedIndex)
            {
                tabButtons[i].GetComponent<Image>().color = selectedTabColor;
            }
            else
            {
                tabButtons[i].GetComponent<Image>().color = unselectedTabColor;
            }
        }
    }

    public void AddTab(string label, GameObject content)
    {
        tabLabels.Add(label);
        tabContents.Add(content);

        GameObject tabButtonObj = Instantiate(tabButtonPrefab, tabButtonParent);
        TabButton tabButton = tabButtonObj.GetComponent<TabButton>();
        tabButton.SetLabel(label);
        tabButton.OnTabSelected += i =>  SelectTab(i) ;

        tabButtons.Add(tabButton);

        if (tabButtons.Count == 1)
        {
            SelectTab(0);
        }
    }

    public void RemoveTab(int index)
    {
        if (index < 0 || index >= tabButtons.Count)
        {
            return;
        }

        Destroy(tabButtons[index].gameObject);
        tabButtons.RemoveAt(index);
        tabLabels.RemoveAt(index);
        tabContents.RemoveAt(index);

        if (selectedIndex == index)
        {
            if (tabButtons.Count > 0)
            {
                SelectTab(0);
            }
            else
            {
                selectedIndex = -1;
            }
        }
        else if (selectedIndex > index)
        {
            selectedIndex--;
        }
    }

    public void SetTabLabel(int index, string label)
    {
        if (index < 0 || index >= tabButtons.Count)
        {
            return;
        }

        tabLabels[index] = label;
        tabButtons[index].SetLabel(label);
    }

    public void SelectTabByIndex(int index)
    {
        if (index < 0 || index >= tabButtons.Count)
        {
            return;
        }

        SelectTab(index);
    }
}
