using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{

    private Dictionary<string, int> items = new Dictionary<string, int>();
    void Start()
    {
        AddItem("����", 5);
        AddItem("������", 2);

        UseItem("����");

        PrintInventory();
    }

    void AddItem(string itemName, int quantity)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] += quantity;
        }
        else
        {
            items.Add(itemName, quantity);
        }
    }
    
    void UseItem(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName]--;
            if (items[itemName] <= 0)
            {
                items.Remove(itemName);
            }
            Debug.Log("����� ������ : " + itemName + ".");
        }
        else
        {
            Debug.Log("������ " + itemName + " �� �κ��丮���� ã�� �� ����.");
        }
    }

    void PrintInventory()
    {
        foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log("������ : " + item.Key + ", ���� : " + item.Value);
        }
    }
   
    void Update()
    {
        
    }
}
