using AcunMedyaAkademiHafta4Odev2;

GeneralManager generalManager = new GeneralManager();
Manager manager = new Manager();    
Intern intern = new Intern();   
Programmer programmer = new Programmer();

double totalSalary = 0;
totalSalary += generalManager.SalaryInfo() + manager.SalaryInfo() + intern.SalaryInfo() + programmer.SalaryInfo();
Console.WriteLine("Total salary is " + totalSalary.ToString("F3"));