using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemInfo : MonoBehaviour
{
    public int slotId;
    public int itemId;

    public void InitDummy(int slotId, int itemId)
    {
        this.slotId = slotId;   
        this.itemId = itemId;       
    }
}
