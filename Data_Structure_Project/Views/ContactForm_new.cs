using Data_Structure_Project.Controls;
using Data_Structure_Project.DesignControls;
using Data_Structure_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure_Project.Views
{
    public partial class ContactForm_new : Form
    {
        DSCM<Contact> dscm = new DSCM<Contact>();

        private void reset()
        {
            txt_name.Text = "";
            txt_mobile.Text = "";
            txt_mobile2.Text = "";
            txt_mobile3.Text = "";
            txt_email.Text = "";
            txt_email2.Text = "";
            txt_email3.Text = "";
            txt_address.Text = "";
            combx_relationship.SelectedIndex = 0;
            radi_female.Checked = false;
            radi_male.Checked = false;

            //btn_remove.Visible = false;
            //btn_edit.Visible = false;
            //btn_reloadnew.Enabled = false;
            btn_editnew.Enabled = false;

            //txt_search.Text = "";
            panel_status.Visible = false;
            checkbx_block.Checked = false;

        }

        private void loadlsbx()
        {
            //lsbx_show.Items.Clear();
            //foreach (Contact h in dscm.contact())
            //{
            //    lsbx_show.Items.Add(h);
            //}
            loadDetails();
        }

        private bool checkmobile_new(string phonecheck)
        {
            foreach (Contact h in dscm.contact())
            {
                if (phonecheck == h.Mobile) return false;
                else if (phonecheck == h.Mobile2 && phonecheck != "") return false;
                else if (phonecheck == h.Mobile3 && phonecheck != "") return false;
            }
            return true;
        }

        private bool checkid_new(int idcheck)
        {
            foreach (Contact h in dscm.contact()) if (idcheck == h.Id) return false;
            return true;
        }

        public ContactForm_new()
        {
            InitializeComponent();
            panel_info.Enabled = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            UserListControl.id = null;
            //lsbx_show.SelectedItems.Clear();
            reset();
            panel_info.Enabled = true;
            combx_relationship.SelectedIndex = 0;
            radi_male.Checked = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int i = -1;
            if (UserListControl.id != null)
            {
                foreach (Contact contact in dscm.contact())
                {
                    if (int.Parse(UserListControl.id) == contact.Id)
                    {
                        i++;
                        break;
                    }
                    i++;
                    if (i > dscm.getlength() - 2) i = -1;
                }
            }
            
            if (i != -1)
            {
                Contact ct = new Contact();
                ct.Id = int.Parse(UserListControl.id);
                ct.Name = txt_name.Text;
                ct.Mobile = txt_mobile.Text;
                ct.Mobile2 = txt_mobile2.Text;
                ct.Mobile3 = txt_mobile3.Text;
                ct.Email = txt_email.Text;
                ct.Email2 = txt_email2.Text;
                ct.Email3 = txt_email3.Text;
                ct.Address = txt_address.Text;
                ct.Relationship = combx_relationship.Text;
                if (radi_male.Checked) ct.Gender = radi_male.Text;
                else if (radi_female.Checked) ct.Gender = radi_female.Text;
                dscm.edit(i, ct);
                panel_info.Enabled = false;
                if (checkbx_block.Checked) ct.Status = 1;
                else ct.Status = 0;
                reset();
                loadlsbx();
                UserListControl.clicked = false;
            }
            else
            {
                if (txt_name.Text == "") MessageBox.Show("Nhap ten!");
                else if (txt_mobile.Text == "") MessageBox.Show("Nhap sdt!");
                else
                {
                    Contact ct = new Contact();

                    Random rd = new Random();
                    do
                    {
                        ct.Id = rd.Next(1, 5000);
                    } while (checkid_new(ct.Id) == false);
                    ct.Name = txt_name.Text;
                    if (checkmobile_new(txt_mobile.Text) == false) MessageBox.Show("SDT 1 da co!!");
                    else if (checkmobile_new(txt_mobile2.Text) == false) MessageBox.Show("SDT 2 da co!!");
                    else if (checkmobile_new(txt_mobile3.Text) == false) MessageBox.Show("SDT 3 da co!!");
                    else
                    {
                        ct.Mobile = txt_mobile.Text;
                        ct.Mobile2 = txt_mobile2.Text;
                        ct.Mobile3 = txt_mobile3.Text;
                        ct.Email = txt_email.Text;
                        ct.Email2 = txt_email2.Text;
                        ct.Email3 = txt_email3.Text;
                        ct.Address = txt_address.Text;
                        ct.Relationship = combx_relationship.Text;
                        if (radi_male.Checked) ct.Gender = radi_male.Text;
                        else if (radi_female.Checked) ct.Gender = radi_female.Text;
                        ct.Status = 0;
                        dscm.insert(ct);
                        panel_info.Enabled = false;
                        reset();
                        loadlsbx();
                    }

                }
            }
        }

        //private void btn_reload_Click(object sender, EventArgs e)
        //{
        //    loadlsbx();
        //    reset();
        //}

        //private void btn_remove_Click(object sender, EventArgs e)
        //{
        //    dscm.remove(lsbx_show.SelectedIndex);
        //    reset();
        //    loadlsbx();
        //}

        //private void lsbx_show_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (txt_search.Text == "")
        //    {
        //        btn_remove.Visible = true;
        //        btn_edit.Visible = true;
        //        panel_status.Visible = true;
        //    }

        //    if (lsbx_show.SelectedIndex != -1)
        //    {
        //        Contact contact = lsbx_show.SelectedItem as Contact;
        //        txt_name.Text = contact.Name;
        //        txt_mobile.Text = contact.Mobile;
        //        txt_mobile2.Text = contact.Mobile2;
        //        txt_mobile3.Text = contact.Mobile3;
        //        txt_email.Text = contact.Email;
        //        txt_email2.Text = contact.Email2;
        //        txt_email3.Text = contact.Email3;
        //        txt_address.Text = contact.Address;
        //        combx_relationship.Text = contact.Relationship;
        //        if (contact.Gender == "Male") radi_male.Checked = true;
        //        else radi_female.Checked = true;
        //        if (contact.Status == 1) checkbx_block.Checked = true;
        //        else checkbx_block.Checked = false;
        //    }
        //}

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            reset();
            panel_info.Enabled = false;
        }

        //private void btn_edit_Click(object sender, EventArgs e)
        //{
        //    panel_info.Enabled = true;
        //}

        //private void btn_search_Click(object sender, EventArgs e)
        //{
        //    btn_edit.Visible = false;
        //    btn_remove.Visible = false;
        //    lsbx_show.Items.Clear();
        //    foreach (Contact h in dscm.contact())
        //    {
        //        if (String.Compare(txt_search.Text, h.Name, true) == 0) lsbx_show.Items.Add(h);
        //    }
        //}

        private bool Ghi(DSCM<Contact> contact, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (Contact p in contact.A)
                {
                    string line = p.Id + ";" + p.Name + ";" + p.Mobile + ";" + p.Mobile2 + ";" + p.Mobile3
                        + ";" + p.Email + ";" + p.Email2 + ";" + p.Email3 + ";" + p.Address + ";" + p.Relationship + ";" + p.Gender
                        + ";" + p.Status;
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btn_savefile_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\contact.txt";
            bool result = Ghi(dscm, path);
            if (result)
            {
                MessageBox.Show("Luu Thanh Cong!");
            }
        }

        private DSCM<Contact> Doc(string path)
        {
            DSCM<Contact> dsp = new DSCM<Contact>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null) break;
                    string[] arr = line.Split(';');
                    if (arr.Length == 12)
                    {
                        Contact p = new Contact();
                        p.Id = int.Parse(arr[0]);
                        p.Name = arr[1];
                        p.Mobile = arr[2];
                        p.Mobile2 = arr[3];
                        p.Mobile3 = arr[4];
                        p.Email = arr[5];
                        p.Email2 = arr[6];
                        p.Email3 = arr[7];
                        p.Address = arr[8];
                        p.Relationship = arr[9];
                        p.Gender = arr[10];
                        p.Status = int.Parse(arr[11]);
                        dsp.insert(p);
                    }
                }
                sr.Close();
            }
            catch (Exception ex) { throw ex; }
            return dsp;
        }

        private void btn_loadfile_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\contact.txt";
            if (System.IO.File.Exists(path))
            {
                dscm = Doc(path);
                reset();
                loadlsbx();
            }
        }

        private bool GhiBlock(DSCM<Contact> contact, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (Contact p in contact.A)
                {
                    if (p.Status == 1)
                    {
                        string line = p.Mobile + " " + p.Mobile2 + " " + p.Mobile3;
                        sw.WriteLine(line);
                    }
                }
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btn_exportblock_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\PhoneNumberBlock.txt";
            bool result = GhiBlock(dscm, path);
            if (result)
            {
                MessageBox.Show("Export Thanh Cong!");
            }
        }

        private void loadDetails()
        {
            resultContainer.Controls.Clear();
            foreach (Contact data in dscm.contact())
            {
                UserListControl res = new UserListControl();
                res.details(data);
                resultContainer.Controls.Add(res);
            }

        }

        private void txsearch_TextChanged(object sender, EventArgs e)
        {
            if (txsearch.Text.Length >= 1)
            {
                resultContainer.Controls.Clear();
                UserListControl res = new UserListControl();
                //btn_edit.Visible = false;
                //btn_remove.Visible = false;
                foreach (Contact h in dscm.contact())
                {
                    if (String.Compare(txsearch.Text, h.Name, true) == 0)
                    {
                        res.details(h);
                        resultContainer.Controls.Add(res);
                    }
                }
            }
            if (txsearch.Text.Length == 0)
            {
                loadDetails();
                reset();
                panel_info.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (UserListControl.clicked == true)
            {
                if (txsearch.Text == "")
                {
                    btn_removenew.Enabled = true;
                    btn_editnew.Enabled = true;
                    panel_status.Visible = true;
                }
                foreach (Contact contact in dscm.contact())
                {
                    if (int.Parse(UserListControl.id) == contact.Id)
                    {
                        txt_name.Text = contact.Name;
                        txt_mobile.Text = contact.Mobile;
                        txt_mobile2.Text = contact.Mobile2;
                        txt_mobile3.Text = contact.Mobile3;
                        txt_email.Text = contact.Email;
                        txt_email2.Text = contact.Email2;
                        txt_email3.Text = contact.Email3;
                        txt_address.Text = contact.Address;
                        combx_relationship.Text = contact.Relationship;
                        if (contact.Gender == "Male") radi_male.Checked = true;
                        else radi_female.Checked = true;
                        if (contact.Status == 1) checkbx_block.Checked = true;
                        else checkbx_block.Checked = false;
                    }
                }
                UserListControl.clicked = false;
            }
        }

        //private void btn_reloadnew_Click(object sender, EventArgs e)
        //{
        //    loadlsbx();
        //    reset();
        //    panel_info.Enabled = false;
        //}

        private void btn_editnew_Click(object sender, EventArgs e)
        {
            panel_info.Enabled = true;
        }

        private void btn_removenew_Click(object sender, EventArgs e)
        {
            int i = -1;
            foreach (Contact contact in dscm.contact())
            {
                if (int.Parse(UserListControl.id) == contact.Id)
                {
                    i++;
                    break;
                }
                i++;
                if (i > dscm.getlength() - 2) i = -1;
            }
            UserListControl.clicked = false;
            dscm.remove(i);
            reset();
            panel_info.Enabled = false;
            loadlsbx();
        }
    }
}
