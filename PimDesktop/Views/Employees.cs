using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserData = PimDesktop.Business.Utils.Users.UserData;
using EmployeeData = PimDesktop.Business.Utils.Employees.EmployeeData;
using EmployeeFunctions = PimDesktop.Business.Utils.Employees.EmployeeFunctions;
using System.Diagnostics;

namespace PimDesktop
{
    public partial class Employees : Form
    {
        public static int UserStorage { get; set; }
        public static int id_profile { get; set; }

        public Employees(UserData user)
        {
            InitializeComponent();

            UserStorage = user.userId;
            id_profile = user.id_profile;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text == "")
                MessageBox.Show("O campo de matricula não pode ser vazio");

            else
            {
                EmployeeFunctions employeeHandler = new EmployeeFunctions();

                var employeeFound = employeeHandler.getEmployee(textSearch.Text);

                if (employeeFound != null)
                {
                    FillemployeeFound(employeeFound);
                }
                else
                {
                    MessageBox.Show("Funcionário não localizado");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            turnFieldsEnabled();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textId.Text))
            {
                InsertEmployee(sender, e);
            }
            else
            {
                UpdateEmployee(sender, e);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PimDesktop.Views.Menu menu = new PimDesktop.Views.Menu(getUserLoged());
            this.Close();
            menu.Show();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            textId.Text = null;
            textRN.Text = null;
            textName.Text = null;
            dateDemission.CustomFormat = " ";
            turnFieldsEnabled();
            dateDemission.Format = DateTimePickerFormat.Custom;


        }
        private void UpdateEmployee(object sender, EventArgs e)
        {
            Employees reopen = new Employees(getUserLoged());
            EmployeeData EmployeeData = new EmployeeData();
            EmployeeFunctions sendEmployee = new EmployeeFunctions();

            EmployeeData = validateFilledFields("update");

            if (EmployeeData != null)
            {
                if (sendEmployee.putEmployee(EmployeeData))
                {
                    MessageBox.Show("Funcionário atualizado com êxito!");
                    this.Close();
                    reopen.Show();
                }
                else
                {
                    MessageBox.Show("Mátricula inserida já está em uso, preencha com outra Matricula.");
                }
            }
        }

        private void InsertEmployee(object sender, EventArgs e)
        {

            Employees reopen = new Employees(getUserLoged());
            EmployeeData EmployeeData = new EmployeeData();
            EmployeeFunctions sendEmployee = new EmployeeFunctions();

            EmployeeData = validateFilledFields("create");

            if (EmployeeData != null)
            {
                if (sendEmployee.setEmployee(EmployeeData))
                {
                    MessageBox.Show("Funcionário cadastrado com êxito!");
                    this.Close();
                    reopen.Show();
                }
                else
                {
                    MessageBox.Show("Mátricula inserida já está em uso, preencha com outra Matricula.");
                }

            }
        }

        private void FillemployeeFound(EmployeeData employeeFound)
        {
            textId.Text = employeeFound.employeeId.ToString();
            textName.Text = employeeFound.name;
            textRN.Text = employeeFound.registerNumber;
            checkUserEnabled.Checked = employeeFound.enabled;
            dateAdmission.Value = employeeFound.admissionDate;

            if (employeeFound.demissionDate != null)
                dateDemission.Value = (DateTime)employeeFound.demissionDate;

            btnUpdate.Visible = true;
        }

        private void turnFieldsEnabled()
        {
            textRN.Enabled = true;
            textName.Enabled = true;
            textFunction.Enabled = true;
            dateAdmission.Enabled = true;

            if (dateDemission.CustomFormat == " ")
                dateDemission.Enabled = true;

            checkUserEnabled.Enabled = true;
            btnUpdate.Enabled = false;
            btnSaveChanges.Visible = true;
            btnCreateEmployee.Visible = false;
        }

        private EmployeeData validateFilledFields(string type)
        {
            switch (type)
            {
                case "create":
                    return returnValidateCreate();
                    break;
                case "update":
                    return returnValidateUpdate();
                    break;
                default:
                    return null;
                    break;
            }
        }

        private EmployeeData returnValidateUpdate()
        {
            EmployeeData EmployeeData = new EmployeeData();

            if (!string.IsNullOrEmpty(textFunction.Text))
                EmployeeData.function = textFunction.Text;

            EmployeeData.enabled = checkUserEnabled.Checked;
            EmployeeData.employeeId = Convert.ToInt32(textId.Text);

            if (!string.IsNullOrEmpty(textRN.Text))
                EmployeeData.registerNumber = textRN.Text;
            else
            {
                MessageBox.Show("A matricula não pode estar em branco");
                return null;
            }

            EmployeeData.admissionDate = dateAdmission.Value;

            if (dateDemission.CustomFormat != " ")
                EmployeeData.demissionDate = dateDemission.Value;

            return EmployeeData;
        }

        private EmployeeData returnValidateCreate()
        {
            EmployeeData EmployeeData = new EmployeeData();

            if (!string.IsNullOrEmpty(textName.Text))
                EmployeeData.name = textName.Text;
            else
            {
                MessageBox.Show("Necessário preencher o nome");
                return null;
            }

            if (!string.IsNullOrEmpty(textRN.Text))
                EmployeeData.registerNumber = textRN.Text;
            else
            {
                MessageBox.Show("Necessário preencher a Matricula");
                return null;
            }

            if (!string.IsNullOrEmpty(textFunction.Text))
                EmployeeData.function = textFunction.Text;
            else
            {
                MessageBox.Show("Necessário preencher a Função");
                return null;
            }

            if (checkUserEnabled.Checked)
                EmployeeData.enabled = checkUserEnabled.Checked;
            else
            {
                MessageBox.Show("Necessário checar o campo de ativo");
                return null;
            }

            EmployeeData.admissionDate = dateAdmission.Value;

            if (dateDemission.CustomFormat != " ")
                EmployeeData.demissionDate = dateDemission.Value;

            return EmployeeData;
        }

        private void dateDemission_ValueChanged(object sender, EventArgs e)
        {
            dateDemission.CustomFormat = "dd/MM/yyyy";
        }

        private UserData getUserLoged()
        {
            UserData sendUser = new UserData();
            sendUser.id_profile = id_profile;
            sendUser.userId = UserStorage;

            return sendUser;
        }

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {

            }
            else
            {
                btnLogout_Click(sender, e);

            }
        }
    }
}
