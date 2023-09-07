using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainerExample : MonoBehaviour
{
    private GenericContainer<int> intcontainer;
    private GenericContainer<string> stringContainer;
    // Start is called before the first frame update
    void Start()
    {
        intcontainer = new GenericContainer<int>(10);
        stringContainer = new GenericContainer<string>(5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            intcontainer.Add(Random.Range(0, 100));
            DisplayContaineritems(intcontainer);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            string randomstring="item"+Random.Range(0, 100);
            stringContainer.Add(randomstring);
            DisplayContaineritems(stringContainer);

        }
    }

    private void  DisplayContaineritems<T>(GenericContainer<T>container)
    {
        T[] item = container.Getitems();
        string temp = "";
        for(int i = 0; i < item.Length; i++)
        {
            if (item[i] != null)
            {
                temp += item[i].ToString() + "/";
            }
            else
            {
                temp += "Empty /";
            }
        }
        Debug.Log(temp);
    }
}
