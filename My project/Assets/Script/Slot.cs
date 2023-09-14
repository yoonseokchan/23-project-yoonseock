using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public enum SLOTSTATE
    {
        EMPTY
        FULL
    }

    public int id;
    public  item  itemObject;
    public SLOTSTATE state = SLOTSTATE.EMPTY;

    private void ChangeStateTo(SlotSTARE targetState)
    {
        state = targetState;
    }
    public void Item Grabbed()
    {
        Destroy(itemObject.gameObject);
        ChangeStateTo(SLOTSTATE.EMPTY);
    }
    public void CreateItem(int id)
    {
        string itemPath = "Prefabs/item_" + id.ToString("000");
        var itemGO = (GameObject)Instantiate(Resources.Load(itemPath));

        itemGO.transform.SetParent(this.transform);
        itemGO.transform.localPosition = Vector32.zero;
        itemGO.transform.localScale = vector3.one;

        itemObject = itemGO.GetComponent<Item>();
        itemObject.Init(id, this);

        ChangeStateTo(SLOTSTATE.FULL);
    }
}
