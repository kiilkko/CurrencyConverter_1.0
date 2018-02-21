using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter_form : Form
    {
        private ValueConverter converter;

        public Converter_form()
        {
            InitializeComponent();
            converter = new ValueConverter();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            eur_Textbox.Text = converter.GetValue(rubTextbox.Text, "euro");
            eurCourse_textBox.Text = "" + (converter.CourseParsing("euro"));

            usd_Textbox.Text = converter.GetValue(rubTextbox.Text, "dollar");
            usdCourse_textBox.Text = "" + (converter.CourseParsing("dollar"));

            gbp_Textbox.Text = converter.GetValue(rubTextbox.Text, "funt");
            gbpCourse_textBox.Text = "" + (converter.CourseParsing("funt"));


        }
    }
}
