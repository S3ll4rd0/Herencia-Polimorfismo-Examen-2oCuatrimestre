using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen11042022.models;

namespace Examen11042022
{
    public partial class Form1 : Form
    {
        private string tabPageSelected;
        private List<User> users = new List<User>();
        private CheckedListBox listCheckBox;

        public Form1()
        {
            InitializeComponent();
            listCheckBox = sportsCheckedListBox;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            clearAllData();
            userslistView.Items.Clear();   
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            tabPageSelected = skillsTabControl.SelectedTab.Name;
            if (tabPageSelected == "Customer")
            {
                makeNewCustomer();
            }
            else if (tabPageSelected == "Trainer")
            {
                makeNewTrainer();
            }
            else if (tabPageSelected == "Assistant")
            {
                makeNewAssistant();
            }
            else
            {
                MessageBox.Show("Imposible");
            }
        }

        private void makeNewCustomer()
        {
            Client client = new Client(
                Convert.ToInt32(idTextBox.Text),
                dniTextBox.Text,
                nameTextBox.Text,
                surnameTextBox.Text,
                activeCheckBox.Checked,
                inUseCheckBox.Checked,
                subscribeDateTextBox.Text,
                unsubscribeTextBox.Text,
                Convert.ToDouble(feeTextBox.Text)
                );
            ListViewItem item = new ListViewItem(client.Name);
            item.SubItems.Add(client.Surname);
            item.SubItems.Add(client.Active.ToString());
            item.SubItems.Add(client.Working.ToString());
            item.SubItems.Add("Client");
            item.SubItems.Add(client.StartDate);
            item.SubItems.Add(client.EndDate);
            item.SubItems.Add(client.Fee.ToString());
            userslistView.Items.Add(item);
            users.Add(client);
        }

        private void makeNewTrainer()
        {
            CheckedListBox.CheckedIndexCollection indexs = sportsCheckedListBox.CheckedIndices;
            List<string> list = new List<string>();
            for (int i = 0; i < indexs.Count; i++)
            {
                list.Add(sportsCheckedListBox.Items[i].ToString());
            }
            Trainer trainer = new Trainer(
                Convert.ToInt32(idTextBox.Text),
                dniTextBox.Text,
                nameTextBox.Text,
                surnameTextBox.Text,
                activeCheckBox.Checked,
                inUseCheckBox.Checked,
                list, 
                contractStartDateTextBox.Text,
                contractEndDateTextBox.Text,
                float.Parse(SalaryTextBox.Text)
                );
            ListViewItem item = new ListViewItem(trainer.Name);
            item.SubItems.Add(trainer.Surname);
            item.SubItems.Add(trainer.Active.ToString());
            item.SubItems.Add(trainer.Working.ToString());
            item.SubItems.Add("Trainer");
            item.SubItems.Add(trainer.StartDateOfContract);
            item.SubItems.Add(trainer.EndDateOfContract);
            item.SubItems.Add(trainer.Salary.ToString());
            for (int i = 0; i < list.Count; i++)
            {
                item.SubItems.Add(list[i]);
            }
            userslistView.Items.Add(item);
            users.Add(trainer);
        }

        private void makeNewAssistant()
        {
            Worker worker = new Worker(
                Convert.ToInt32(idTextBox.Text),
                dniTextBox.Text,
                nameTextBox.Text,
                surnameTextBox.Text,
                activeCheckBox.Checked,
                inUseCheckBox.Checked,
                contractStartDatePersonaTextBox.Text,
                functionTextBox.Text,
                baseSalarytextBox.Text
                );
            ListViewItem item = new ListViewItem(worker.Name);
            item.SubItems.Add(worker.Surname);
            item.SubItems.Add(worker.Active.ToString());
            item.SubItems.Add(worker.Working.ToString());
            item.SubItems.Add("Worker");
            item.SubItems.Add(worker.DateOfContract);
            item.SubItems.Add(worker.Work);
            item.SubItems.Add(worker.Salary.ToString());
            userslistView.Items.Add(item);
            users.Add(worker);
        }

        private void userslistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userslistView.SelectedItems.Count > 0)
            {
                showGeneralData(userslistView.SelectedItems[0]);
                string type = userslistView.SelectedItems[0].SubItems[4].Text;
                if (type == "Client")
                {
                    showSelectedClient(userslistView.SelectedItems[0]);
                }
                else if (type == "Trainer")
                {
                    showSelectedTrainer(userslistView.SelectedItems[0]);
                }
                else if (type == "Worker")
                {
                    showSelectedWorker(userslistView.SelectedItems[0]);
                }
            }
            else
            {
                return;
            }
        }

        private void showGeneralData(ListViewItem item)
        {
            clearAllData();
            nameTextBox.Text = item.Text;
            surnameTextBox.Text = item.SubItems[1].Text;
            if (item.SubItems[2].Text == "True") { activeCheckBox.Checked = true; } else { activeCheckBox.Checked = false; }
            if (item.SubItems[3].Text == "True") { inUseCheckBox.Checked = true; } else { inUseCheckBox.Checked = false; }
        }

        private void showSelectedClient(ListViewItem item)
        {
            subscribeDateTextBox.Text = item.SubItems[5].Text;
            unsubscribeTextBox.Text = item.SubItems[6].Text;
            feeTextBox.Text = item.SubItems[7].Text;

        }

        private void showSelectedTrainer(ListViewItem item)
        {
            contractStartDateTextBox.Text = item.SubItems[5].Text;
            contractEndDateTextBox.Text = item.SubItems[6].Text;
            SalaryTextBox.Text = item.SubItems[7].Text;

            /*
            for (int i = 8; i < item.SubItems.Count; i++)
            {
                for (int j = 0; j < sportsCheckedListBox.Items.Count; j++)
                {
                    if (item.SubItems[i].Text == sportsCheckedListBox.Items[j].ToString())
                    {
                        sportsCheckedListBox.CheckedItems[i];
                    }
                }
            }
            */

        }

        private void showSelectedWorker(ListViewItem item)
        {
            contractStartDatePersonaTextBox.Text = item.SubItems[5].Text;
            functionTextBox.Text = item.SubItems[6].Text;
            baseSalarytextBox.Text = item.SubItems[7].Text;
        }

        private void clearAllData()
        {
            idTextBox.Text = "";
            dniTextBox.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            activeCheckBox.Checked = false;
            inUseCheckBox.Checked = false;
            subscribeDateTextBox.Text = "";
            unsubscribeTextBox.Text = "";
            feeTextBox.Text = "";
            for (int i = 0; i < sportsCheckedListBox.Items.Count; i++)
            {
                sportsCheckedListBox.SetItemChecked(i, false);
            }
            contractEndDateTextBox.Text = "";
            contractEndDateTextBox.Text = "";
            contractStartDatePersonaTextBox.Text = "";
            functionTextBox.Text = "";
            SalaryTextBox.Text = "";
        }
    }
}
