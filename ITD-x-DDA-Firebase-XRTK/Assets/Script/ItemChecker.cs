using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ItemChecker : MonoBehaviour
{
    [Header("Item Found UI")]
    public TMP_Text ItemFoundUpdate;

    XRDirectInteractor DirectInteractor;
    public string ItemTag;

    private void Awake()
    {
        DirectInteractor = GetComponent<XRDirectInteractor>();
    }

    public void isGrab()
    {
        if (DirectInteractor.interactablesSelected.Count > 0 && DirectInteractor.interactablesSelected[0].transform.CompareTag(ItemTag))
        {
            Debug.Log(ItemTag);

            ItemFoundUpdate.text += "1";
        }
    }
}
