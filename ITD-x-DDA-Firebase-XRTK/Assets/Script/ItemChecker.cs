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
    public string[] ItemTag;
    public static int CountItems;

    private void Awake()
    {
        DirectInteractor = GetComponent<XRDirectInteractor>();
    }

    public void isGrab()
    {
        if (DirectInteractor.interactablesSelected.Count > 0 && DirectInteractor.interactablesSelected[0].transform.CompareTag(ItemTag[0]))
        {
            if (CountItems > 0)
            {
                CountItems++;

                Debug.Log("Item Found");

                ItemFoundUpdate.text = CountItems.ToString();

                if (ItemFoundUpdate.text == "1")
                {
                    Debug.Log("Item Existed");
                }
            }
        }
    }
}
