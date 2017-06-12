using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HaffmanCoder
{
    public partial class mainForm : Form
    {
        #region Конструктор формы

        public mainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Обработчики событий формы

        /// <summary>
        /// Обработчик события нажатия кнопки "закодировать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void code_button_Click(object sender, EventArgs e)
        {
            try
            {
                Source_Code_textBox.Text = Convert.ToString(HafmanCoder.incode(Convert.ToInt32(Source_textBox.Text)), 2);
            }
            catch
            {
                MessageBox.Show("Некорректный воод данных");
                Source_textBox.Text = "";
                return;
            }

            tranceived_textBox.Text = "";
            tranceived_Code_textBox.Text = "";
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Исправить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tranceive_button_Click(object sender, EventArgs e)
        {
            try
            {
                tranceived_Code_textBox.Text = Convert.ToString(HafmanCoder.correction(Convert.ToInt32(Source_Code_textBox.Text, 2)), 2);
            }
            catch 
            {
                MessageBox.Show("Последовательность закодирована некорректно!");
                Source_Code_textBox.Text = "";
                return;
            }
            tranceived_textBox.Text = (HafmanCoder.decode(Convert.ToInt32(tranceived_Code_textBox.Text,2))).ToString();
        }

        #endregion

    }
}
