using SudokuSolver;
using System;
using System.Windows.Forms;

namespace SudokuForm
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var arryEnum = Enum.GetValues(typeof(AlphabeticalEnum));
            var valueStrings = new string[arryEnum.Length][];

            foreach (var line in arryEnum)
            {
                valueStrings[line.GetHashCode()] = new string[arryEnum.Length];
                for (int col = 0; col < arryEnum.Length; col++)
                {

                    var coord = $"{line}{col + 1}";
                    var txt = this.Controls[coord];
                    var txtValue = (txt as TextBox)?.Text;
                    valueStrings[line.GetHashCode()][col] = txtValue;
                }
            }

            SudokuValidator validator = new SudokuValidator();
            var isValid = validator.IsValid(valueStrings);
            if (!isValid)
            {
                MessageBox.Show("Não é válido");
            }
            else
            {
                MessageBox.Show("Válido");
            }
        }
    }
}
