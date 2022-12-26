using System.Text;

namespace Lab3CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        List<Factory> _factories = new List<Factory>(5);
        private void GenerateFactoryBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<Person> people = GetPeople();
            List <Workshop> workshops = new List<Workshop>();
            workshops.Add(new Workshop(1, 500, 350, 150, 0, 0, 15, 5, 3000, 6000));
            workshops.Add(new Workshop(2, 500, 350, 150, 0, 0, 15, 5, 3000, 6000));
            workshops.Add(new Workshop(3, 500, 350, 150, 0, 0, 15, 5, 3000, 6000));
            workshops.Add(new Workshop(4, 500, 350, 150, 0, 0, 15, 5, 3000, 6000));
            Factory factory = new Factory($"Factory {random.Next(0, 500)}", workshops, people);
            _factories.Add(factory);
            UpdateList();
            MessageBox.Show("Done!");
        }
        private List<Person> GetPeople()
        {
            List<Person> people = new List<Person>(10);
            for (int i = 0; i < random.Next(100, 300); i++)
            {
                string uniqeKey = GeneateUniqeKeyForPerson();
                if (i < 50)
                {
                    people.Add(new Master(random.Next(1, 4), $"Master {i}", uniqeKey, random.Next(1, 4)));
                    continue;
                }
                people.Add(new Worker(Convert.ToBoolean(random.Next(0, 2)), $"Worker {i}", uniqeKey, random.Next(1, 4)));
            }
            return people;
        }
        
        private void UpdateList()
        {
            ComboBoxCurrentSelectedFactory.Items.Clear();
            ComboBoxSecondaryFactory.Items.Clear();
            foreach (var factory in _factories)
            {
                ComboBoxCurrentSelectedFactory.Items.Add(factory);
                ComboBoxSecondaryFactory.Items.Add(factory);
            }
            ComboBoxCurrentSelectedFactory.Text = String.Empty;
            ComboBoxSecondaryFactory.Text = String.Empty;
        }
        public bool TryGetFactoryFromCheckBox(ComboBox comboBox, out Factory? factory)
        {
            factory = (Factory)comboBox.SelectedItem;
            if (factory == null)
            {
                return false;
            }
            return true;
        }
        private string GeneateUniqeKeyForPerson()
        {
            string[] keyNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append(keyNumbers[random.Next(0, keyNumbers.Length - 1)]);
            }
            return stringBuilder.ToString();
        }

        private void FirePersonBtn_Click(object sender, EventArgs e)
        {
            if(!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            try
            {
                factory.FirePerson(TextBoxUniqeKey.Text);
                MessageBox.Show("Done!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HirePersonBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            try
            {
                Person person = new Worker(Convert.ToBoolean(random.Next(0, 1)), $"Worker {random.Next(501, 10000)}", GeneateUniqeKeyForPerson(), random.Next(1, 4));
                factory.HirePerson(person);
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void CompareBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            if (!TryGetFactoryFromCheckBox(ComboBoxSecondaryFactory, out Factory? factorySecondary))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            int res = factory.CompareTo(factorySecondary);
            if(res == 0)
            {
                MessageBox.Show("Factories are equal");
                return;
            }
            if(res == 1)
            {
                MessageBox.Show($"{factory} is larger");
                return;
            }
            MessageBox.Show($"{factorySecondary} is larger");
        }
        private void ShowFullInfoBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            Form showInfo = new ShowInfoForm(factory.GetInfo());
            showInfo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool exists = Directory.Exists(@"..\..\FactoryData");
            if (!exists)
            {
                Directory.CreateDirectory(@"..\..\FactoryData");
            }
        }

        private void SaveToFilesBtn_Click(object sender, EventArgs e)
        {
          
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory factory))
            {
                MessageBox.Show("Factory is not sellected!");
                return;
            }
            factory.SaveToTXTMasters();
            factory.SaveToTXTWorkers();
            factory.SaveToTXTFactoryGeneral();
            MessageBox.Show("Done!");
        }

        private void ShowInfoFromFiles_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory factory))
            {
                MessageBox.Show("Factory is not sellected!");
                return;
            }
            string path = GetPathFromUser();
            if (path == "")
            {
                return;
            }
            Form form = new ShowInfoForm(factory.ReadFileFromPath(path));
            form.Show();
        }
        public string GetPathFromUser()
        {
            string path = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open TXT file";
                ofd.Filter = "txt files(*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            return path;
        }

        private void CopyFactoryBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            _factories.Add(new Factory(factory));
            UpdateList();
            MessageBox.Show("Done!");
        }
    }

}