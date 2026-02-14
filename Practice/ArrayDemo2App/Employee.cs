using System;
class Employee:IComparable<Employee>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CompateTo(Employee other)
    {
        return this.Id.CompareTo(other.Id);
    }
    public override string toString()
    {
        return $"Employee Id is (Id)"+ $"Employee Name is {Name}";
    }
}