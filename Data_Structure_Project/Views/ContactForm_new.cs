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
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;

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

            btn_save.Visible = false;
            panel_status.Visible = false;
            checkbx_block.Checked = false;

            UserListControl.id = null;
            UserListControl.clicked = false;

            txsearch.Text = null;

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
            reset();
            panel_info.Enabled = true;
            combx_relationship.SelectedIndex = 0;
            radi_male.Checked = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (panel_info.Enabled)
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
                    int n;
                    bool successfullyParsed = int.TryParse(txt_mobile.Text, out n);
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
                    loadDetails();
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
                        if (pathavatar != null)
                        {
                            CopyImage(pathavatar, ct.Id.ToString());
                            ct.Avatar = Application.StartupPath + "\\" + ct.Id + ".jpg";
                        }
                        else
                        {
                            ct.Avatar = null;
                        }
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
                            pathavatar = null;
                            ptb_avatar.Image = Properties.Resources.icons8_user_35;
                            reset();
                            loadDetails();
                        }

                    }
                }
            }

        }
        private bool Write(DSCM<Contact> contact, string path)
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
            bool result = Write(dscm, path);
            if (result)
            {
                MessageBox.Show("Luu Thanh Cong!");
            }
        }

        private DSCM<Contact> Read(string path)
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
                dscm = Read(path);
                reset();
                loadDetails();
            }
        }

        private bool WriteBlock(DSCM<Contact> contact, string path)
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
                int n;
                bool successfullyParsed = int.TryParse(txsearch.Text, out n);
                if (successfullyParsed)
                {
                    resultContainer.Controls.Clear();
                    List<Contact> contacts = new List<Contact>();
                    foreach (Contact h in dscm.contact())
                    {
                        string phone = "";
                        for (int i = 0; i < txsearch.Text.Length; i++)
                        {
                            if (i == h.Mobile.Length) break;
                            phone += h.Mobile[i];
                            if (i == h.Mobile.Length - 1) break;
                        }
                        if (String.Compare(txsearch.Text, phone, true) == 0)
                        {
                            contacts.Add(h);
                        }
                        string phone2 = "";
                        for (int i = 0; i < txsearch.Text.Length; i++)
                        {
                            if (i == h.Mobile2.Length) break;
                            phone2 += h.Mobile2[i];
                            if (i == h.Mobile2.Length - 1) break;
                        }
                        if (String.Compare(txsearch.Text, phone2, true) == 0)
                        {
                            contacts.Add(h);
                        }
                        string phone3 = "";
                        for (int i = 0; i < txsearch.Text.Length; i++)
                        {
                            if (i == h.Mobile3.Length) break;
                            phone3 += h.Mobile3[i];
                            if (i == h.Mobile3.Length - 1) break;
                        }
                        if (String.Compare(txsearch.Text, phone3, true) == 0)
                        {
                            contacts.Add(h);
                        }
                    }
                    foreach (Contact h in contacts)
                    {
                        string phone = "";
                        for (int i = 0; i < txsearch.Text.Length; i++)
                        {
                            if (i == h.Mobile.Length) break;
                            phone += h.Mobile[i];
                            if (i == h.Mobile.Length - 1) break;
                        }
                        if (String.Compare(txsearch.Text, phone, true) == 0)
                        {
                            UserListControl res = new UserListControl();
                            res.detailsMobile(h);
                            resultContainer.Controls.Add(res);
                        }
                        string phone2 = "";
                        for (int i = 0; i < txsearch.Text.Length; i++)
                        {
                            if (i == h.Mobile2.Length) break;
                            phone2 += h.Mobile2[i];
                            if (i == h.Mobile2.Length - 1) break;
                        }
                        if (String.Compare(txsearch.Text, phone2, true) == 0)
                        {
                            UserListControl res = new UserListControl();
                            res.detailsMobile2(h);
                            resultContainer.Controls.Add(res);
                        }
                        string phone3 = "";
                        for (int i = 0; i < txsearch.Text.Length; i++)
                        {
                            if (i == h.Mobile3.Length) break;
                            phone3 += h.Mobile3[i];
                            if (i == h.Mobile3.Length - 1) break;
                        }
                        if (String.Compare(txsearch.Text, phone3, true) == 0)
                        {
                            UserListControl res = new UserListControl();
                            res.detailsMobile3(h);
                            resultContainer.Controls.Add(res);
                        }
                    }

                }
                else
                {
                    resultContainer.Controls.Clear();
                    foreach (Contact h in dscm.contact())
                    {
                        string name = "";
                        for (int i = 0; i < txsearch.Text.Length; i++)
                        {
                            name += h.Name[i];
                            if (i == h.Name.Length - 1) break;
                        }
                        if (String.Compare(txsearch.Text, name, true) == 0)
                        {
                            UserListControl res = new UserListControl();
                            res.details(h);
                            resultContainer.Controls.Add(res);
                        }
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

        private void timer_Tick(object sender, EventArgs e)
        {
            if (UserListControl.clicked == true)
            {
                panel_status.Visible = true;
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

        private void btn_editnew_Click(object sender, EventArgs e)
        {
            if (UserListControl.id != null)
            {
                panel_info.Enabled = true;
                btn_save.Visible = true;
            }

        }

        private void btn_removenew_Click(object sender, EventArgs e)
        {
            if (UserListControl.id != null)
            {
                string name = "";
                foreach (Contact contact in dscm.contact())
                {
                    if (int.Parse(UserListControl.id) == contact.Id)
                    {
                        name = contact.Name;
                        break;
                    }
                }
                DialogResult dialogResult = MessageBox.Show("Remove " + name, "Are you sure ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
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
                    dscm.remove(i);
                    reset();
                    panel_info.Enabled = false;
                    loadDetails();
                }
            }

        }

        private void ContactForm_new_Load(object sender, EventArgs e)
        {

        }

        private void btn_newcontact_Click(object sender, EventArgs e)
        {
            reset();
            btn_save.Visible = true;
            panel_info.Enabled = true;
            combx_relationship.SelectedIndex = 0;
            radi_male.Checked = true;
        }

        private void btn_exportBlockNew_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\PhoneNumberBlock.txt";
            bool result = WriteBlock(dscm, path);
            if (result)
            {
                MessageBox.Show("Export Thanh Cong!");

                var p = new Process();
                p.StartInfo = new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
        }

        private void ContactForm_new_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Click: Cancel anything";

        }

        private void ContactForm_new_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
        }

        private void btn_newcontact_MouseHover(object sender, EventArgs e)
        {
            btn_newcontact.BackColor = Color.LightGray;
            lb_namefeat.Text = "NEW CONTACT";
            lb_contentfeat.Text = "Click: Create a new contact!";
        }

        private void btn_newcontact_MouseLeave(object sender, EventArgs e)
        {
            btn_newcontact.BackColor = Color.Gainsboro;
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btn_editnew_MouseHover(object sender, EventArgs e)
        {
            btn_editnew.BackColor = Color.LightGray;
            lb_namefeat.Text = "EDIT CONTACT";
            lb_contentfeat.Text = "Click: Edit contact!";
        }

        private void btn_editnew_MouseLeave(object sender, EventArgs e)
        {
            btn_editnew.BackColor = Color.Gainsboro;
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btn_removenew_MouseHover(object sender, EventArgs e)
        {
            btn_removenew.BackColor = Color.LightGray;
            lb_namefeat.Text = "REMOVE CONTACT";
            lb_contentfeat.Text = "Click: Remove contact!";
        }

        private void btn_removenew_MouseLeave(object sender, EventArgs e)
        {
            btn_removenew.BackColor = Color.Gainsboro;
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
        }

        private void btn_exportBlockNew_MouseHover(object sender, EventArgs e)
        {
            btn_exportBlockNew.BackColor = Color.LightGray;
            lb_namefeat.Text = "EXPORT BLOCK-CONTACT";
            lb_contentfeat.Text = "Click: Export to file text!";
        }

        private void btn_exportBlockNew_MouseLeave(object sender, EventArgs e)
        {
            btn_exportBlockNew.BackColor = Color.Gainsboro;
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txt_name_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "NAME";
            lb_contentfeat.Text = "Text your name!!";
        }

        private void txt_name_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txt_mobile_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "1st MOBILE";
            lb_contentfeat.Text = "Text your 1st mobile!";
        }

        private void txt_mobile_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txt_mobile2_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "2nd MOBILE";
            lb_contentfeat.Text = "Text your 2nd mobile!";
        }

        private void txt_mobile2_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txt_mobile3_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "3rd MOBILE";
            lb_contentfeat.Text = "Text your 3rd mobile!";
        }

        private void txt_mobile3_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txt_email_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "1st EMAIL";
            lb_contentfeat.Text = "Text your 1st email!";
        }

        private void txt_email_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txt_email2_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "2nd EMAIL";
            lb_contentfeat.Text = "Text your 2nd email!";
        }

        private void txt_email2_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txt_email3_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "3rd EMAIL";
            lb_contentfeat.Text = "Text your 3rd email!";
        }

        private void txt_email3_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txt_address_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "ADDRESS";
            lb_contentfeat.Text = "Text your address!";
        }

        private void txt_address_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void combx_relationship_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "RELATIONSHIP";
            lb_contentfeat.Text = "Choose our relationship!";
        }

        private void combx_relationship_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radi_male_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "MALE";
            lb_contentfeat.Text = "Choose their gender!";
        }

        private void radi_male_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radi_female_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "FEMALE";
            lb_contentfeat.Text = "Choose their gender!";
        }

        private void radi_female_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void checkbx_block_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "STATUS";
            lb_contentfeat.Text = "If you want to block they!";
        }

        private void checkbx_block_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btn_save_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "SAVE CONTACT";
            lb_contentfeat.Text = "Save info from this form!";
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txsearch_MouseHover(object sender, EventArgs e)
        {
            lb_namefeat.Text = "SEARCH";
            lb_contentfeat.Text = "Search mobile or name!";
        }

        private void txsearch_MouseLeave(object sender, EventArgs e)
        {
            lb_namefeat.Text = "CONTACT BOOK";
            lb_contentfeat.Text = "Hello world!";
            lb_namefeat.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void ContactForm_new_Click(object sender, EventArgs e)
        {
            reset();
            panel_info.Enabled = false;
        }

        public static void CopyImage(string src, string id)
        {
            string destination = Application.StartupPath;
            string namefile = id + ".jpg";
            string destinationFile = Path.Combine(destination, namefile);

            File.Copy(src, destinationFile, true);
        }

        string pathavatar = null;
        private void ptb_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ptb_avatar.Image = Image.FromFile(ofd.FileName);
                pathavatar = ofd.FileName;
            }
        }
    }
}
