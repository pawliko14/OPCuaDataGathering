using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LocalApplicationDataGathering.Opc_parameters_form;

namespace LocalApplicationDataGathering
{
    public partial class modern_new_version : Form
    {
        private static System.Timers.Timer DummyTimer = null;
        private string now;
        private string datetime = DateTime.Today.ToString();

        public modern_new_version()
        {
            InitializeComponent();


            customizeDesign();
            this.Startcounting();


        }

        private void customizeDesign()
        {
            panel_parameters.Visible = false;
            panel_Connections.Visible = false;
            panel_Help.Visible = false;
            panel_AdditionalGroup.Visible = false;
        }

        private void hideSubMenus()
        {
            if (panel_parameters.Visible == true)
                panel_parameters.Visible = false;
            if (panel_Connections.Visible == true)
                panel_Connections.Visible = false;
            if (panel_Help.Visible == true)
                panel_Help.Visible = false;
            if (panel_AdditionalGroup.Visible == true)
                panel_Help.Visible = false;
        }

        private void ShowSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenus();
                subMenu.Visible = true;
                CurrentTab_label.Text = subMenu.Name;
            }
            else
                subMenu.Visible = false;
        }

        private void button_parameters_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panel_parameters);
        }

        private void button_Connections_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panel_Connections);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panel_Help);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panel_AdditionalGroup);

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {

            if (activeForm != null)
            {
                //    activeForm.Close();                        
            }

           
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                Child_panel_form.Controls.Add(childForm);
                Child_panel_form.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

             //   getAllexistingForms();            
        }


        

        private void button_home_Click(object sender, EventArgs e)
        {
        //     openChildForm
        }

        private void button_allParameters_Click(object sender, EventArgs e)
        {

            Boolean form_already_exists = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.Equals("child_form"))
                {
                    form_already_exists = true;
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Tag = form;
                    form.BringToFront();
                    form.Show();
                }
            }

            if (form_already_exists == false)
                openChildForm(new child_form());
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            DummyTimer.Stop();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        // timer tick

        private void timer_tick(object sender, EventArgs e)
        {
            now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt");
            Time_label.Invoke(new Action(delegate ()
            {
                Time_label.Text = now;
            }));

           
      
        }

        private void Startcounting()
        {
            DummyTimer = new System.Timers.Timer(1000 * 1); // 5 sec interval
            DummyTimer.Enabled = true;
            DummyTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer_tick);
            DummyTimer.AutoReset = true;

            DummyTimer.Start();
        }

        private void button_OPCParameters_Click(object sender, EventArgs e)
        {
            Boolean form_already_exists = false;
            foreach (Form form in Application.OpenForms)
            {
                 if (form.Name.Equals("Opc_parameters_form"))
                {
                    form_already_exists =  true;
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Tag = form;
                    form.BringToFront();
                    form.Show();
                }
            }
         
            if(form_already_exists == false)
                openChildForm(new Opc_parameters_form());
            
        }

  



        // print all existing forms
        public void getAllexistingForms()
        {
            StringBuilder builder = new StringBuilder();

            foreach(Form form in Application.OpenForms)
            {
                    builder.Append(form.Name);
                    builder.Append("\n");
            }
            MessageBox.Show(builder.ToString() ,"existing forms");

        }

        private void button_DataGatheringParameters_Click(object sender, EventArgs e)
        {

        }

        private void button_showDataBags_Click(object sender, EventArgs e)
        {
            Boolean form_already_exists = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.Equals("DataBags"))
                {
                    form_already_exists = true;
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Tag = form;
                    form.BringToFront();
                    form.Show();
                }
            }

            if (form_already_exists == false)
                openChildForm(new DataBags());


            getAllexistingForms();


        }

        private void button_Manipulate_Click(object sender, EventArgs e)
        {    

                   Boolean form_already_exists = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.Equals("DataBag_manipulate"))
                {
                    form_already_exists = true;
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Tag = form;
                    form.BringToFront();
                    form.Show();
                }
            }

            if (form_already_exists == false)
                openChildForm(new DataBag_manipulate());


            getAllexistingForms();


        }
    }
}
