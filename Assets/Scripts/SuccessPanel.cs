using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessPanel : MonoBehaviour
{
    public GameObject successPanel;

    public void SuccessPanelEnterButton()
    {
        successPanel.SetActive(false);
    }

}
