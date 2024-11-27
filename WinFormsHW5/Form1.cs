namespace WinFormsHW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            List<RadioButton> radioButtons = new List<RadioButton>() { radioButton1, radioButton2};
            string ingredients = string.Join(", ", checkedListBox1.CheckedItems.Cast<string>());


            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    label.Text = radioButton.Text;
                }
            }
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(checkedListBox1.Text) || string.IsNullOrEmpty(label.Text) || string.IsNullOrEmpty
                (dateTimePicker1.Text))
            {
                MessageBox.Show("Please enter all lines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Name: {textBox1.Text}\nPhone: {textBox2.Text}\nDish: {comboBox1.Text}\nIngredients: {ingredients}\nType: {label.Text}\nTime: {dateTimePicker1.Text}, {DateTime.Now}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
