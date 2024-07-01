using MaterialSkin;
using MaterialSkin.Controls;
using WinFormsAppSource.Enums;

namespace WinFormsAppSource
{
    public partial class Form1 : MaterialForm
    {
        // Define the custom event
        public event EventHandler SortButtonClicked;

        public Form1()
        {
            InitializeComponent();

            //Material Form
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public string InputString => txtInput.Text;
        public string SelectedStrategy => cmbStrategy.SelectedItem.ToString();


        public void SetSortedString(string sorted)
        {
            this.lblSortedString.Text = sorted;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // Populate the combo box with enum values
            cmbStrategy.DataSource = Enum.GetValues(typeof(SortingStrategy));
            // Optionally, set a default selected item
            cmbStrategy.SelectedIndex = 0;

            this.CheckTextInput();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Debug statements to track method entry and exit
            Console.WriteLine("btnSort_Click started");
            if (string.IsNullOrEmpty(this.txtInput.Text))
            {
                string message = "Text input is required!";
                string title = "Warning";
                MessageBox.Show(message, title);
                return;
            }
            else if (string.IsNullOrEmpty(this.cmbStrategy.Text))
            {
                string message = "Strategy selection is required!";
                string title = "Warning";
                MessageBox.Show(message, title);
                return;
            }
            else
            {
                SortButtonClicked?.Invoke(this, EventArgs.Empty);
            }


  
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            this.CheckTextInput();
        }

        private void CheckTextInput()
        {
            if (string.IsNullOrEmpty(this.txtInput.Text))
            {
                this.lblSortedString.Text = string.Empty;
                this.lblSortedString.Visible = false;
            }
            else
            {
                this.lblSortedString.Visible = true;
            }
        }

    }
}
