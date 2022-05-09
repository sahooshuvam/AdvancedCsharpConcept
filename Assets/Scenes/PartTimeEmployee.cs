using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTimeEmployee : Employee
{
    public int hoursWorked;
    public int hourlyRate;
    public override void CalculateMonthySalary()
    {
        Debug.Log("Part time Salary : " +(hourlyRate * hoursWorked));
    }

    private void Start()
    {
        CalculateMonthySalary();
    }
}
