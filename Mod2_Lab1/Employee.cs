﻿using System;



namespace Mod2_Lab1
{
    public class Employee
    {
        private string name;
        private double baseSalary;
        private int iD;
        private static int employeeCount = 1;

        public string Name { get => name; set => name = value; }
        public double BaseSalary { get => baseSalary; set => baseSalary = value; }

        public int ID { get => iD; set => iD = value; }

        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

       
        public String getName()
        {
            return this.Name;
        }

      
            public int getEmployeeID()
        {
            return this.ID;
        }

        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        public virtual String employeeStatus()
        {
            return toString() + " is in the company's system";
        }
    }

    
}