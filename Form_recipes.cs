﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuck_Time_Bakery
{
    public partial class Form_recipes : Form
    {
        public Form_recipes()
        {
            InitializeComponent();
        }

        private static Form_recipes f;
        public static Form_recipes fr
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_recipes();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void RecipesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recipesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_recipes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.chuck_TimeDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Recipes". При необходимости она может быть перемещена или удалена.
            this.recipesTableAdapter.Fill(this.chuck_TimeDataSet.Recipes);

        }
    }
}
