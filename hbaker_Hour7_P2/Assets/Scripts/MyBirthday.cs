using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        int daysInMonth = 31;
        
        int birthdayDay = 29;
        
        for (int day = 1; day <= daysInMonth; day++)
        {
            if (day == birthdayDay)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }
}