using CafeOtomasyon.Business.Validators;
using CafeOtomasyon.Entity.Concrete;
using FluentValidation.Results;

namespace CafeOtomasyon.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new();
            m.MenuAdi = textBox1.Text;
            MenuValidator validationRules = new MenuValidator();
            ValidationResult results = validationRules.Validate(m);
            if (results.IsValid)
            {

            }
            else
            {
                foreach (var item in results.Errors)
                {

                }
            }
        }
    }
}
