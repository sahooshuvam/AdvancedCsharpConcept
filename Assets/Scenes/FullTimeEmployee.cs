using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTimeEmployee : Employee
{
    public int salary;
    public override void CalculateMonthySalary()
    {
        Debug.Log("Salary of Full time Employee :" +salary);
    }
}
