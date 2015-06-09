using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker:Human
    {
        private double weekSalary;
        private byte workHoursPerDay;
        private byte workDaysInWeek;
        public double WeekSalary{
            get { return this.weekSalary; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("salary shoud be positive ");
                }
                this.weekSalary=value;
            }
        }







        public byte WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
               set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("workhours should be positive  ");
                }
                this.workHoursPerDay=value;
            }

        }
        public byte WorkDaysInWeek { get; set; }


        public double MoneyPerHour()
        {
            double salary = this.weekSalary / (workHoursPerDay * WorkDaysInWeek);
            return salary;
        }

        public Worker(string fName, string lName, double salary, byte workHours, byte workDays)
            : base(fName, lName)
        {
            this.WeekSalary = salary;
            this.WorkDaysInWeek = workDays;
            this.WorkHoursPerDay = workHours;
        }
        public override string ToString()
        {
            return this.FirstName + "  " + this.LastName + "  " + this.WeekSalary + "  " + this.WorkDaysInWeek + "  " + this.WorkHoursPerDay + "  " + this.MoneyPerHour();
        }
    }
}
