using Syncfusion.Maui.Data;
using System.Collections.ObjectModel;
using System.Data;

namespace ColumnSelectionSample
{
    public class EmployeeViewModel : IDisposable
    {     
        public EmployeeViewModel()
        {
            PopulateData();
            employees = GetEmployeeDetails(2000);
            employeesDetails = GetNewEmployeeDetails(100000);
            this.CreateDataTable();
            employeeList = this.CreateList(1000);
            this.CustomerNames = Customers.ToObservableCollection();
            titleCollection = GetTitles();
        }

        public void ItemsSourceRefresh()
        {
            for (int i = 1; i < 10; i++)
            {
                employees.Insert(0, new Employee()
                {
                    EmployeeID = 1001 - i,
                    Name = "Sean Jacobson",
                    IDNumber = 101 - i,
                    ContactID = 201 - i,
                    ManagerID = 3 + i,
                    LoginID = "sean2",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Title = "GM",
                    MaritalStatus = i % 2 == 0 ? "Single" : "Married",
                    HireDate = new DateTime(2023, 01, 03),
                    BirthDate = new DateTime(i + 2023, 01, 03),
                    SickLeaveHours = 15 + i,
                    Salary = 6000 + i,
                    EmployeeStatus = i % 2 == 0 ? true : false,
                    Rating = 1 + i,
                });
            }
        }

        public void LoadMoreItems()
        {
            for (int i = 1; i < 10; i++)
            {
                employees.Add(new Employee()
                {
                    EmployeeID = 1101 + i,
                    Name = "Sean Jacobson",
                    IDNumber = 100 + i,
                    ContactID = 200 + i,
                    ManagerID = 3 + i,
                    LoginID = "sean2",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Title = "GM",
                    MaritalStatus = i % 2 == 0 ? "Single" : "Married",
                    HireDate = new DateTime(2023, 01, 03),
                    BirthDate = new DateTime(i + 2023, 01, 03),
                    SickLeaveHours = 15 + i,
                    Salary = 6000 + i,
                    EmployeeStatus = i % 2 == 0 ? true : false,
                    Rating = 1 + i,
                });
            }
        }

        private ObservableCollection<Employee> employees;
        private ObservableCollection<Employee> employeesDetails;
        private List<Employee> employeeList;
        public List<Employee> EmployeeList
        {
            get
            {
                return employeeList;
            }
        }

        private void CreateDataTable()
        {
            EmployeeCollection = new DataTable();
            EmployeeCollection.Columns.Add("EmployeeID", typeof(int));
            EmployeeCollection.Columns.Add("Company", typeof(string));
            EmployeeCollection.Columns.Add("Name", typeof(string));
            EmployeeCollection.Columns.Add("City", typeof(string));
            EmployeeCollection.Rows.Add(1, "Alferds Futterkiste", "Maria Anders", "Berlin");
            EmployeeCollection.Rows.Add(2, "Ana Trujilo Emparedados y Hela", "Ana Trujilo", "Mexico D.F.");
            EmployeeCollection.Rows.Add(3, "Antonio Moreno Taqueria", "Antonio Moreno", "Mexico D.F.");
            EmployeeCollection.Rows.Add(4, "Around the Horn", "Thomas Hardy", "London");
            EmployeeCollection.Rows.Add(5, "Berglunds Snabbkop", "Christina Berglund", "Lulea");
            EmployeeCollection.Rows.Add(6, "Blauer see Delikatessen", "Hanna Moss", "Mannheim");
            EmployeeCollection.Rows.Add(7, "Blondel Pere et Fils", "Erederique Citeaux", "Strasbourg");
            EmployeeCollection.Rows.Add(8, "Bolids Comidas Preparadas", "Martin Sommer", "Madrid");
            EmployeeCollection.Rows.Add(9, "Bon App", "Laurence Lebihan", "Marseille");
            EmployeeCollection.Rows.Add(10, "Bottom-Dollar Markets", "Elizabeth Lincoln", "Tsawassen");
            EmployeeCollection.Rows.Add(11, "B's Beverages", "Victoria Ashworth", "London");
            EmployeeCollection.Rows.Add(12, "Cactus Comidas para llevar", "Patricio Simpson", "Bueno Aires");
            EmployeeCollection.Rows.Add(13, "Centro Comercial Moctezuma", "Francisco Chang", "Mexico D.F.");
            EmployeeCollection.Rows.Add(14, "Chop-Suey Chinese", "Yang Wang", "Bern");
            EmployeeCollection.Rows.Add(15, "Comercio Minerio", "Pedro Afonso", "Sao Paulo");
            EmployeeCollection.Rows.Add(16, "Consolidated Holdings", "Elizabeth Brown", "London");
            EmployeeCollection.Rows.Add(17, "Drachenblut Entier", "Sven Ottlieb", "Aachen");
            EmployeeCollection.Rows.Add(18, "Dumonde Entier", "Janine Labrune", "Nantes");
            EmployeeCollection.Rows.Add(19, "Eastern Connection", "Ann Devon", "London");
            EmployeeCollection.Rows.Add(20, "Ernst Handel", "Roland Mendel", "Graz");
        }

        private List<Employee> CreateList(int count)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i < count; i++)
            {
                var emp = new Employee
                {
                    EmployeeID = 1000 + i,
                    Name = "Phyllis Allen",
                    IDNumber = 100 + i,
                    ContactID = 200 + i,
                    ManagerID = 3 + i,
                    LoginID = "sean2",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Title = "GM",
                    MaritalStatus = i % 2 == 0 ? "Single" : "Married",
                    HireDate = new DateTime(2023, 01, 03),
                    BirthDate = new DateTime(2023, 01, 03),
                    SickLeaveHours = 15 + i,
                    Salary = 6000 + i,
                    EmployeeStatus = i % 2 == 0 ? true : false,
                    Rating = 1 + i,
                };
                employees.Add(emp);
            }
            return employees;
        }


        public DataTable EmployeeCollection { get; set; }

        public ObservableCollection<string> CustomerNames { get; set; }

        /// <summary>
        /// contains more rows and column
        /// </summary>
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return employees;
            }

        }

        public ObservableCollection<Employee> EmployeesDetails
        {
            get
            {
                return employeesDetails;
            }

        }

        private ObservableCollection<string> titleCollection;

        internal string[] Customers = new string[] { "Adams", "Crowley", "Ellis", "Gable", "Irvine", "Keefe", "Mendoza", "Owens", "Rooney", "Wadded", };

        Dictionary<string, string> loginID = new Dictionary<string, string>();
        Dictionary<string, string> gender = new Dictionary<string, string>();

        /// <summary>
        /// Get the EmployeeDetails
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public ObservableCollection<Employee> GetEmployeeDetails(int count)
        {
            employees = new ObservableCollection<Employee>();
            for (int i = 1; i < 100; i++)
            {
                employees.Add(new Employee()
                {
                    EmployeeID = 1000 + i,
                    Name = "Sean Jacobson",
                    IDNumber = 100 + i,
                    ContactID = 200 + i,
                    ManagerID = 3 + i,
                    LoginID = "sean2",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Title = "GM",
                    MaritalStatus = i % 2 == 0 ? "Single" : "Married",
                    HireDate = new DateTime(2023, 01, 03),
                    BirthDate = new DateTime(i + 2023, 01, 03),
                    SickLeaveHours = 15 + i,
                    Salary = 6000 + i,
                    EmployeeStatus = i % 2 == 0 ? true : false,
                    Rating = 1 + i,
                });
            }

            return employees;
        }

        public ObservableCollection<Employee> GetNewEmployeeDetails(int count)
        {
            employeesDetails = new ObservableCollection<Employee>();
            for (int i = 1; i < 100000; i++)
            {
                employeesDetails.Add(new Employee()
                {
                    EmployeeID = 50 + i,
                    Name = "John",
                    IDNumber = 10 + i,
                    ContactID = 30 + i,
                    ManagerID = 3 + i,
                    LoginID = "John2",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Title = "GM",
                    MaritalStatus = i % 2 == 0 ? "Single" : "Married",
                    HireDate = new DateTime(2023, 01, 03),
                    BirthDate = new DateTime(2023, 01, 03),
                    SickLeaveHours = 15 + i,
                    Salary = 5000 + i,
                    EmployeeStatus = i % 2 == 0 ? true : false,
                    Rating = 1 + i,
                });
            }

            return employeesDetails;
        }

        public ObservableCollection<Employee> GetEmployeeDetail()
        {
            employees = new ObservableCollection<Employee>();
            ImageSource img = "image0.png";
            for (int i = 1; i < 100; i++)
            {
                employees.Add(new Employee()
                {
                });
            }

            return employees;
        }

        private static ObservableCollection<string> GetTitles()
        {
            ObservableCollection<string> titles = new ObservableCollection<string>();
            titles.Add("Marketing Assistant");
            titles.Add("Engineering Manager");
            titles.Add("Senior Tool Designer");
            titles.Add("Tool Designer");
            titles.Add("Marketing Manager");
            titles.Add("Production Supervisor - WC60");
            titles.Add("Production Technician - WC10");
            titles.Add("Design Engineer");
            titles.Add("Production Technician - WC10");
            titles.Add("Design Engineer");
            titles.Add("Vice President of Engineering");
            titles.Add("Production Technician - WC10");
            titles.Add("Production Supervisor - WC50");
            titles.Add("Production Technician - WC10");
            titles.Add("Production Supervisor - WC60");
            titles.Add("Production Technician - WC10");
            titles.Add("Production Supervisor - WC60");
            titles.Add("Production Technician - WC10");
            titles.Add("Production Technician - WC30");
            titles.Add("Production Control Manager");
            titles.Add("Production Technician - WC45");
            titles.Add("Production Technician - WC45");
            titles.Add("Production Technician - WC30");
            titles.Add("Production Supervisor - WC10");
            titles.Add("Production Technician - WC20");
            titles.Add("Production Technician - WC40");
            titles.Add("Network Administrator");
            titles.Add("Production Technician - WC50");
            titles.Add("Human Resources Manager");
            titles.Add("Production Technician - WC40");
            titles.Add("Production Technician - WC30");
            titles.Add("Production Technician - WC30");
            titles.Add("Stocker");
            titles.Add("Shipping and Receiving Clerk");
            titles.Add("Production Technician - WC50");
            titles.Add("Production Technician - WC60");
            titles.Add("Production Supervisor - WC50");
            titles.Add("Production Technician - WC20");
            titles.Add("Production Technician - WC45");
            titles.Add("Quality Assurance Supervisor");
            titles.Add("Information Services Manager");
            titles.Add("Production Technician - WC50");
            titles.Add("Master Scheduler");
            titles.Add("Production Technician - WC40");
            titles.Add("Marketing Specialist");
            titles.Add("Recruiter");
            titles.Add("Production Technician - WC50");
            titles.Add("Maintenance Supervisor");
            titles.Add("Production Technician - WC30");
            return titles;
        }
        /// <summary>
        /// Populate the data for Gender
        /// </summary>
        private void PopulateData()
        {
            gender.Add("Sean Jacobson", "Male");
            gender.Add("Phyllis Allen", "Male");
            gender.Add("Marvin Allen", "Male");
            gender.Add("Michael Allen", "Male");
            gender.Add("Cecil Allison", "Male");
            gender.Add("Oscar Alpuerto", "Male");
            gender.Add("Sandra Altamirano", "Female");
            gender.Add("Selena Alvarad", "Female");
            gender.Add("Emilio Alvaro", "Female");
            gender.Add("Maxwell Amland", "Male");
            gender.Add("Mae Anderson", "Male");
            gender.Add("Ramona Antrim", "Female");
            gender.Add("Sabria Appelbaum", "Male");
            gender.Add("Hannah Arakawa", "Male");
            gender.Add("Kyley Arbelaez", "Male");
            gender.Add("Tom Johnston", "Female");
            gender.Add("Thomas Armstrong", "Female");
            gender.Add("John Arthur", "Male");
            gender.Add("Chris Ashton", "Female");
            gender.Add("Teresa Atkinson", "Male");
            gender.Add("John Ault", "Male");
            gender.Add("Robert Avalos", "Male");
            gender.Add("Stephen Ayers", "Male");
            gender.Add("Phillip Bacalzo", "Male");
            gender.Add("Gustavo Achong", "Male");
            gender.Add("Catherine Abel", "Male");
            gender.Add("Kim Abercrombie", "Male");
            gender.Add("Humberto Acevedo", "Male");
            gender.Add("Pilar Ackerman", "Male");
            gender.Add("Frances Adams", "Female");
            gender.Add("Margar Smith", "Male");
            gender.Add("Carla Adams", "Male");
            gender.Add("Jay Adams", "Male");
            gender.Add("Ronald Adina", "Female");
            gender.Add("Samuel Agcaoili", "Male");
            gender.Add("James Aguilar", "Female");
            gender.Add("Robert Ahlering", "Male");
            gender.Add("Francois Ferrier", "Male");
            gender.Add("Kim Akers", "Male");
            gender.Add("Lili Alameda", "Female");
            gender.Add("Amy Alberts", "Male");
            gender.Add("Anna Albright", "Female");
            gender.Add("Milton Albury", "Male");
            gender.Add("Paul Alcorn", "Male");
            gender.Add("Gregory Alderson", "Male");
            gender.Add("J. Phillip Alexander", "Male");
            gender.Add("Michelle Alexander", "Male");
            gender.Add("Daniel Blanco", "Male");
            gender.Add("Cory Booth", "Male");
            gender.Add("James Bailey", "Female");

            loginID.Add("Sean Jacobson", "sean2");
            loginID.Add("Phyllis Allen", "phyllis0");
            loginID.Add("Marvin Allen", "marvin0");
            loginID.Add("Michael Allen", "michael10");
            loginID.Add("Cecil Allison", "cecil0");
            loginID.Add("Oscar Alpuerto", "oscar0");
            loginID.Add("Sandra Altamirano", "sandra1");
            loginID.Add("Selena Alvarad", "selena0");
            loginID.Add("Emilio Alvaro", "emilio0");
            loginID.Add("Maxwell Amland", "maxwell0");
            loginID.Add("Mae Anderson", "mae0");
            loginID.Add("Ramona Antrim", "ramona0");
            loginID.Add("Sabria Appelbaum", "sabria0");
            loginID.Add("Hannah Arakawa", "hannah0");
            loginID.Add("Kyley Arbelaez", "kyley0");
            loginID.Add("Tom Johnston", "tom1");
            loginID.Add("Thomas Armstrong", "thomas1");
            loginID.Add("John Arthur", "john6");
            loginID.Add("Chris Ashton", "chris3");
            loginID.Add("Teresa Atkinson", "teresa0");
            loginID.Add("John Ault", "john7");
            loginID.Add("Robert Avalos", "robert2");
            loginID.Add("Stephen Ayers", "stephen1");
            loginID.Add("Phillip Bacalzo", "phillip0");
            loginID.Add("Gustavo Achong", "gustavo0");
            loginID.Add("Catherine Abel", "catherine0");
            loginID.Add("Kim Abercrombie", "kim2");
            loginID.Add("Humberto Acevedo", "humberto0");
            loginID.Add("Pilar Ackerman", "pilar1");
            loginID.Add("Frances Adams", "frances0");
            loginID.Add("Margar Smith", "margaret0");
            loginID.Add("Carla Adams", "carla0");
            loginID.Add("Jay Adams", "jay1");
            loginID.Add("Ronald Adina", "ronald0");
            loginID.Add("Samuel Agcaoili", "samuel0");
            loginID.Add("James Aguilar", "james2");
            loginID.Add("Robert Ahlering", "robert1");
            loginID.Add("Francois Ferrier", "françois1");
            loginID.Add("Kim Akers", "kim3");
            loginID.Add("Lili Alameda", "lili0");
            loginID.Add("Amy Alberts", "amy1");
            loginID.Add("Anna Albright", "anna0");
            loginID.Add("Milton Albury", "milton0");
            loginID.Add("Paul Alcorn", "paul2");
            loginID.Add("Gregory Alderson", "gregory0");
            loginID.Add("J. Phillip Alexander", "jphillip0");
            loginID.Add("Michelle Alexander", "michelle0");
            loginID.Add("Daniel Blanco", "daniel0");
            loginID.Add("Cory Booth", "cory0");
            loginID.Add("James Bailey", "james3");

        }

        string[] title = new string[]
    {
            "Assistant",
            "Engineering",
            "Designer",
            "Manager",
            "WC60",
            "WC10",
            "Design Engineer",
            "WC10",
            "Vice President",
            "Stocker",
            "Master Scheduler",
            "Recruiter",
            "Maintenance Supervisor",
    };

        string[] employeeName = new string[]
        {
            "Sean Jacobson",
            "Phyllis Allen",
            "Marvin Allen",
            "Michael Allen",
            "Cecil Allison",
            "Oscar Alpuerto",
            "Sandra Altamirano",
            "Selena Alvarad",
            "Emilio Alvaro",
            "Maxwell Amland",
            "Mae Anderson",
            "Ramona Antrim",
            "Sabria Appelbaum",
            "Hannah Arakawa",
            "Kyley Arbelaez",
            "Tom Johnston",
            "Thomas Armstrong",
            "John Arthur",
            "Chris Ashton",
            "Teresa Atkinson",
            "John Ault",
            "Robert Avalos",
            "Stephen Ayers",
            "Phillip Bacalzo",
            "Gustavo Achong",
            "Catherine Abel",
            "Kim Abercrombie",
            "Humberto Acevedo",
            "Pilar Ackerman",
            "Frances Adams",
            "Margar Smith",
            "Carla Adams",
            "Jay Adams",
            "Ronald Adina",
            "Samuel Agcaoili",
            "James Aguilar",
            "Robert Ahlering",
            "Francois Ferrier",
            "Kim Akers",
            "Lili Alameda",
            "Amy Alberts",
            "Anna Albright",
            "Milton Albury",
            "Paul Alcorn",
            "Gregory Alderson",
            "J. Phillip Alexander",
            "Michelle Alexander",
            "Daniel Blanco",
            "Cory Booth",
            "James Bailey"
        };



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isdisposable)
        {
            if (Employees != null)
            {
                Employees.Clear();
            }
        }
    }
}
