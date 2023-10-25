using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class RO : MonoBehaviour
{
    async void Start()
    {
        List<Task<int>> orderTasks = new List<Task<int>>();

        for (int i = 1; i <= 5; i++)
        {
            int tableNumber = i;
            Task<int> orderTask = PlaceOrderAsync(tableNumber);
            orderTasks.Add(orderTask);
        }

        await Task.WhenAll(orderTasks);

        Debug.Log("��� �ֹ��� �Ϸ�Ǿ����ϴ�.");
    }

    async Task<int> PlaceOrderAsync(int tableNumber)
    {
        Debug.Log($"���̺� {tableNumber} �ֹ��� �޽��ϴ�.");

        await Task.Delay(2000); // �ֹ� ó���� �ùķ��̼��ϱ� ���� ���

        Debug.Log($"���̺� {tableNumber} �ֹ��� �Ϸ�Ǿ����ϴ�.");
        return tableNumber;
    }
}


