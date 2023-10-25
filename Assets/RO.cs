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

        Debug.Log("모든 주문이 완료되었습니다.");
    }

    async Task<int> PlaceOrderAsync(int tableNumber)
    {
        Debug.Log($"테이블 {tableNumber} 주문을 받습니다.");

        await Task.Delay(2000); // 주문 처리를 시뮬레이션하기 위한 대기

        Debug.Log($"테이블 {tableNumber} 주문이 완료되었습니다.");
        return tableNumber;
    }
}


