
using System.Security.AccessControl;
namespace Assignment2_RutviM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormReset();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerAppointment.CustomFormat = "dd MMM yyyy"; 
            dateTimePickerAppointment.Format = DateTimePickerFormat.Custom;
            dateTimePickerAppointment.Text = FormatAppointmentDate(dateTimePickerAppointment.Value);
        }

        private void richTextBoxProblem_TextChanged(object sender, EventArgs e)
        {

        }

        // Event handler for the prefill button click event
        private void btnPrefill_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "Isabella Thompston";
            txtAddress.Text = "65 Harold Ave";
            txtCity.Text = "Kitchener";
            txtProvince.Text = "ON";
            txtPostalCode.Text = "N2A 2H9";
            txtHomePhone.Text = "111-222-8596";
            txtCellPhone.Text = "548-888-9999";
            txtEmail.Text = "example@domain.com";
            txtMake_Model.Text = "Honda Civic";
            txtYear.Text = "2019";
            richTextBoxProblem.Text = "Example: Oil Change";
            dateTimePickerAppointment.Value = DateTime.Now.AddDays(7);
            dateTimePickerAppointment.Text = FormatAppointmentDate(dateTimePickerAppointment.Value);
        }

        // Event handler for the book appointment button click e
        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;

            if (!ValidateFields())
                return;

            AppointmentData appointment = GetAppointmentDataFromForm();

            if (SaveAppointment(appointment))
            {
                MessageBox.Show("Appointment booked successfully!", "Appointment Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Failed to book an appointment", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FormReset();


        }
        // Method to validate all fields in the form
        private bool ValidateFields()
        {
            bool isDataValid = true;
            lblError.Text = string.Empty;

            // Validate customer name
            string customerName = txtCustomerName.Text.Trim();
            if (string.IsNullOrWhiteSpace(customerName))
            {
                PrintError("Please enter customer name.");
                txtCustomerName.Focus();
                isDataValid = false;
            }

            // Validate email and postal information
            string email = txtEmail.Text.Trim();
            bool hasEmail = !string.IsNullOrWhiteSpace(email);
            if (!hasEmail && !HasPostalInformation())
            {
                PrintError("Please provide either an email or the postal information.");
                txtEmail.Focus();
                isDataValid = false;
            }

            // Validate province code
            string provinceCode = txtProvince.Text.Trim();
            if (!string.IsNullOrWhiteSpace(provinceCode) && !ValidationHelper.IsValidProvinceCode(provinceCode))
            {
                PrintError("Invalid province code. Please enter a valid 2-letter code.");
                txtProvince.Focus();
                isDataValid = false;
            }

            // Validate postal code
            string postalCode = txtPostalCode.Text.Trim();
            if (!string.IsNullOrWhiteSpace(postalCode) && !ValidationHelper.IsValidPostalCode(postalCode))
            {
                PrintError("Invalid postal code. Please enter a valid Canadian postal code.");
                txtPostalCode.Focus();
                isDataValid = false;
            }

            // Validate phone numbers
            string homePhone = txtHomePhone.Text.Trim();
            string cellPhone = txtCellPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(homePhone) && string.IsNullOrWhiteSpace(cellPhone))
            {
                PrintError("Please provide at least one home or cell phone number.");
                txtHomePhone.Focus();
                isDataValid = false;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(homePhone) && !ValidationHelper.IsValidPhoneNumber(homePhone))
                {
                    PrintError("Invalid home phone number. Please enter a valid phone number in the format '123-123-1234'.");
                    txtHomePhone.Focus();
                    isDataValid = false;
                }

                if (!string.IsNullOrWhiteSpace(cellPhone) && !ValidationHelper.IsValidPhoneNumber(cellPhone))
                {
                    PrintError("Invalid cell phone number. Please enter a valid phone number in the format '123-123-1234'.");
                    txtCellPhone.Focus();
                    isDataValid = false;
                }
            }

            // Email validation
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !IsValidEmail(txtEmail.Text.Trim()))
            {
                PrintError("Invalid email format.");
                txtEmail.Focus();
                isDataValid = false;
            }

            // Validate make & model
            string makeAndModel = txtMake_Model.Text.Trim();
            if (string.IsNullOrWhiteSpace(makeAndModel))
            {
                PrintError("Please enter the make and model of your car.");
                txtMake_Model.Focus();
                isDataValid = false;
            }

            // Validate year
            string year = txtYear.Text.Trim();
            if (!string.IsNullOrWhiteSpace(year) && !ValidationHelper.IsYearValid(year))
            {
                PrintError("Invalid year. Please enter a valid year between 1900 and the current year +1.");
                txtYear.Focus();
                isDataValid = false;
            }

            // Validate appointment date
            DateTime appointmentDate = dateTimePickerAppointment.Value;
            if (appointmentDate < DateTime.Today)
            {
                PrintError("Invalid appointment date. Please select a date in the future.");
                dateTimePickerAppointment.Focus();
                isDataValid = false;
            }

            // Validate problem
            string problem = richTextBoxProblem.Text.Trim();
            if (string.IsNullOrWhiteSpace(problem))
            {
                PrintError("Please enter a problem description for your car.");
                richTextBoxProblem.Focus();
                isDataValid = false;
            }

            return isDataValid;
        }

        // Method to check if any postal information is provided
        private bool HasPostalInformation()
        {
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string province = txtProvince.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();

            return !string.IsNullOrWhiteSpace(address) || !string.IsNullOrWhiteSpace(city) ||
                !string.IsNullOrWhiteSpace(province) || !string.IsNullOrWhiteSpace(postalCode);
        }

        // Method to print an error message
        private void PrintError(string errorMessage)
        {
            lblError.Text += $"{errorMessage}{Environment.NewLine}";
        }

        // Method to retrieve appointment data from the form
        private AppointmentData GetAppointmentDataFromForm()
        {
            string customerName = ValidationHelper.Capitalize(txtCustomerName.Text.Trim());
            string address = ValidationHelper.Capitalize(txtAddress.Text.Trim());
            string city = ValidationHelper.Capitalize(txtCity.Text.Trim());
            string provinceCode = txtProvince.Text.Trim().ToUpper();
            string postalCode = txtPostalCode.Text.Trim().ToUpper();
            string homePhone = ValidationHelper.FormatPhoneNumber(txtHomePhone.Text.Trim());
            string cellPhone = ValidationHelper.FormatPhoneNumber(txtCellPhone.Text.Trim());
            string email = txtEmail.Text.Trim();
            string makeAndModel = ValidationHelper.Capitalize(txtMake_Model.Text.Trim());
            string year = txtYear.Text.Trim();
            DateTime appointmentDate = dateTimePickerAppointment.Value;
            string Problem = ValidationHelper.Capitalize(richTextBoxProblem.Text.Trim());

            return new AppointmentData
            {
                CustomerName = customerName,
                Address = address,
                City = city,
                provinceCode = provinceCode,
                PostalCode = postalCode,
                HomePhone = homePhone,
                CellPhone = cellPhone,
                Email = email,
                MakeAndModel = makeAndModel,
                Year = year,
                AppointmentDate = appointmentDate,
                Problem = Problem
            };
        }

        // Method to save the appointment data to a txt file
        private bool SaveAppointment(AppointmentData appointment)
        {

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appointments.txt");

                int count = 1;
                if (File.Exists(path))
                {
                    string[] rows = File.ReadAllLines(path);
                    count = rows.Length / (15 + 1);
                }

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine($"Appointment Count: {count}");
                    writer.WriteLine($"\nCustomer Name: {appointment.CustomerName}");
                    writer.WriteLine($"Address: {appointment.Address}");
                    writer.WriteLine($"City: {appointment.City}");
                    writer.WriteLine($"Province Code: {appointment.provinceCode}");
                    writer.WriteLine($"Postal Code: {appointment.PostalCode}");
                    writer.WriteLine($"Home Phone: {appointment.HomePhone}");
                    writer.WriteLine($"Cell Phone: {appointment.CellPhone}");
                    writer.WriteLine($"Email: {appointment.Email}");
                    writer.WriteLine($"Make & Model: {appointment.MakeAndModel}");
                    writer.WriteLine($"Year: {appointment.Year}");
                    writer.WriteLine($"Appointment Date: {appointment.AppointmentDate.ToString("dd MMM yyyy")}");
                    writer.WriteLine($"Problem Description: {appointment.Problem}");
                    writer.WriteLine();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save the appointment: {ex.Message}");
                return false;
            }
        }

        // Method to reset the form to its initial state
        private void FormReset()
        {
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtProvince.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtHomePhone.Text = string.Empty;
            txtCellPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMake_Model.Text = string.Empty;
            txtYear.Text = string.Empty;
            dateTimePickerAppointment.Value = DateTime.Now;
            richTextBoxProblem.Text = string.Empty;
            lblError.Text = string.Empty;

            dateTimePickerAppointment.CustomFormat = "dd MMM yyyy"; 
            dateTimePickerAppointment.Format = DateTimePickerFormat.Custom;

            // Reset appointment date text
            dateTimePickerAppointment.Text = FormatAppointmentDate(dateTimePickerAppointment.Value);
        }

        // Event handler for the reset button click event
        private void btnReset_Click(object sender, EventArgs e)
        {
            FormReset();
        }

        // Event handler for the close button click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Method to validate if an email address is valid
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Method to format the appointment date as a string
        private string FormatAppointmentDate(DateTime appointmentDate)
        {
            return appointmentDate.ToString("dd MMM yyyy");
        }
    }
}