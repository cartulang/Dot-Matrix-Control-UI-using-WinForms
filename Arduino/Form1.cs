using System.IO.Ports;

namespace Arduino
{
    public partial class Form1 : Form
    {
        private readonly SerialPort _serialPort;
        private readonly string[] ports;
        private readonly List<string> prevInputs = new() { "" };
        private string currentInput = null!;
        private readonly List<string> directions = new() {"None", "Left", "Right", "Up", "Down" };
        public Form1()
        {
            InitializeComponent();
            _serialPort = new SerialPort() { BaudRate = 9600, WriteTimeout = 1000, ReadTimeout = 1000 };
            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                PortList.Items.Add(port);
            }

            foreach(string direction in directions)
            {
                DirectionList.Items.Add(direction);
            }

            PortList.SelectedIndex = 1;
            DirectionList.SelectedIndex = 0;
        }

        private void PortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serialPort.PortName = ports[PortList.SelectedIndex];
            PortSelected.Text = ports[PortList.SelectedIndex];
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            currentInput = InputText.Text.Trim();
            bool isValid = ValidateInput(currentInput);
            
            if(!isValid)
            {
                return;
            }

            if (_serialPort.PortName == "" || _serialPort.PortName == null)
            {
                MessageBox.Show("No port selected.");
                return;
            }

            try
            {
                _serialPort.Open();
                _serialPort.WriteLine(currentInput);
                _serialPort.Close();
                prevInputs.Add(currentInput);
                InputText.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeFontBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Open();
                _serialPort.WriteLine("#");
                _serialPort.WriteLine(prevInputs[prevInputs.ToArray().Length - 1]);
                _serialPort.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            prevInputs.Clear();
            prevInputs.Add("");
            try
            {
                _serialPort.Open();
                _serialPort.WriteLine("$");
                _serialPort.Close();
                DirectionList.SelectedIndex = 0;
                InputText.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DirectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDirection = SetDirection(directions[DirectionList.SelectedIndex]);

            try
            {
                _serialPort.Open();
                _serialPort.WriteLine(selectedDirection);
                _serialPort.WriteLine(prevInputs[prevInputs.ToArray().Length - 1]);
                _serialPort.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static string SetDirection(string direction)
        {
            return direction switch
            {
                "Left" => "^",
                "Right" => "&",
                "Up" => "*",
                "Down" => "(",
                _ => "%",
            };
        }

        private static bool ValidateInput(string input)
        {
            bool isAlphaNumeric = input.All(c => Char.IsLetterOrDigit(c));

            if(!isAlphaNumeric)
            {
                MessageBox.Show("Input can only have letters and numbers.");
                return false;
            }

            if (input == "" || input == null)
            {
                MessageBox.Show("Input cannot be empty.");
                return false;
            }

            return true;
        }
    }
}