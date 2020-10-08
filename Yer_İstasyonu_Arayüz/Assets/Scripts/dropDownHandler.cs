using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropDownHandler : MonoBehaviour
{
    public Dropdown myDropdown;

    void Start()
    {
        myDropdown.onValueChanged.AddListener(delegate {
            myDropdownValueChangedHandler(myDropdown);
        });
        myDropdown.value = 0;
    }
    void Destroy()
    {
    myDropdown.onValueChanged.RemoveAllListeners();
    }

    private void myDropdownValueChangedHandler(Dropdown target)
    {
    Debug.Log("selected: " + target.value);
    }

    public int getDropdownValue(Dropdown target)
    {
        return target.value;
    }
   
    public void SetDropdownIndex(int index)
    {
    myDropdown.value = index;
    }
}
