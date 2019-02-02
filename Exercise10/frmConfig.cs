/*
 * EXERCISE............: Exercise 10.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP.....: 2º Interface Development 
 * PROJECT.............: Forms III. Serial Port and DLL
 * DATE................: 30 Jan 2019
 */


using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using FormUtilities;
using System.Drawing;

namespace Exercise10
{
    public partial class frmConfig : Form
    {
        #region attributes
        public static SerialPort serialPort;
        private string name;
        private int velocity;
        private int databit;
        private int filesNo;
        private bool portClosed;
        static ComboBox comboBox;
        #endregion
        #region constructor
        public frmConfig()
        {
            InitializeComponent();
            Options.CreateRegKey(@"SOFTWARE\P10", "Uses");
            StartForm();           
        }
        #endregion
        #region voids and methods
        private void StartForm()
        {
            Size = new Size(268, 249);
            serialPort = new SerialPort();
            comboBox = cmbAvailablePorts;
            SetPortName();
            filesNo = 0;
            btnContinue.Enabled = true;
            portClosed = true;
            SetPortStopBits();
            SetPortParity();
            lblHeader.Text = "Modo Activo: ";
            chatTextoToolStripMenuItem.Enabled = false;
            enviarFicheroToolStripMenuItem.Enabled = false;
            recibirFicheroToolStripMenuItem.Enabled = false;
            txtSend.Enabled = false;
            txtBox.ReadOnly = true;
            btnSend.Enabled = false;
            btnClosePort.Enabled = false;
            cmbAvailablePorts.Text = serialPort.PortName;
            cmbPar.Text = serialPort.Parity.ToString();
            cmbStop.Text = serialPort.StopBits.ToString();
            txtVelocity.Text = serialPort.BaudRate.ToString();
            txtBitCar.Text = serialPort.DataBits.ToString();
            serialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
        }

        public static void SetPortName()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox.Items.Add(s);
                Console.WriteLine(s);
            }
        }

        public void SetPortParity()
        {

            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                cmbPar.Items.Add(s);
            }            
        }

        public void SetPortStopBits()
        {
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                cmbStop.Items.Add(s);
            }
        }
        #endregion
        #region events
        private void cmbAvailablePorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(name);
            name = comboBox.SelectedText;
        }

        private void txtVelocity_TextChanged(object sender, EventArgs e)
        {
            string baudRate;
            int number;
            baudRate = txtVelocity.Text;

            if (baudRate == "" || !int.TryParse(baudRate, out number))
            {
                MessageBox.Show("Valor incorrecto. Se le ha asignado la velocidad: " 
                    + serialPort.BaudRate.ToString());
                txtVelocity.Text = serialPort.BaudRate.ToString();
                baudRate = serialPort.BaudRate.ToString();
            }

            velocity = int.Parse(baudRate);
        }

        private void txtBitCar_TextChanged(object sender, EventArgs e)
        {
            string dataBits;
            int number;
            dataBits = txtBitCar.Text;

            if (dataBits == "" || !int.TryParse(dataBits, out number))
            {
                dataBits = serialPort.DataBits.ToString();
                MessageBox.Show("Valor incorrecto. Se le ha asignado: "
                   + dataBits);
                txtBitCar.Text = dataBits;              
            }
            
            try
            {
                databit = int.Parse(dataBits.ToUpperInvariant());
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Bit de Carácter fuera de rango. Se ha asignado 5 por defecto");
                databit = 5;
                txtBitCar.Text = "5";
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
            try
            {
                serialPort = new SerialPort(cmbAvailablePorts.Text, velocity, 
                    (Parity)Enum.Parse(typeof(Parity), cmbPar.Text, true), databit, 
                    (StopBits)Enum.Parse(typeof(StopBits), cmbStop.Text, true));
                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;
                // Console.WriteLine(cmbAvailablePorts.Text + velocity + (Parity)Enum.Parse(typeof(Parity), cmbPar.Text, true) + databit + (StopBits)Enum.Parse(typeof(StopBits), cmbStop.Text, true));
                serialPort.Open();
                txtBox.AppendText("Connectado...\n");
                portClosed = false;
                btnContinue.Enabled = false;
                btnClosePort.Enabled = true;
                cmbAvailablePorts.Enabled = false;
                cmbPar.Enabled = false;
                cmbStop.Enabled = false;
                txtBitCar.Enabled = false;
                txtVelocity.Enabled = false;
                chatTextoToolStripMenuItem.Enabled = true;
                enviarFicheroToolStripMenuItem.Enabled = true;
                recibirFicheroToolStripMenuItem.Enabled = true;
                txtBox.AppendText(Environment.NewLine);                
            }
            catch(Exception)
            {
                MessageBox.Show("El puerto ya está abierto o los parámetros introducidos no son válidos");
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {    
            try
            {
                string read = serialPort.ReadExisting();
                if(!read.Equals(""))
                {
                   txtBox.AppendText("Recibido: " + read + "\n");
                   txtBox.AppendText(Environment.NewLine);
                }
                else
                {
                    filesNo++;
                    if(filesNo > 10)
                    {
                        try
                        {
                            MessageBox.Show("El puerto ya se ha cerrado por seguridad.");
                            txtBox.AppendText("Desconnectado...\n");
                            txtBox.AppendText(Environment.NewLine);
                            serialPort.Close();
                            StartForm();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El puerto ya está cerrado");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al leer el mensaje de texto. Compruebe que los" +
                    " formularios se encuentran en modo CHAT");
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.AppendText("Desconnectado...\n");
                txtBox.AppendText(Environment.NewLine);
                serialPort.Close();
                StartForm();
            }
            catch(Exception)
            {
                MessageBox.Show("El puerto ya está cerrado");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(portClosed == false)
            {
                serialPort.Write(txtSend.Text);
                txtBox.AppendText("Enviado: " + txtSend.Text + "\n");
                txtBox.AppendText(Environment.NewLine);
            }
            else
            {
                MessageBox.Show("El puerto está cerrado");
            }
        }
       
        private void enviarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(477, 249);
            lblHeader.Text = "Modo Activo: Envío";
            if (portClosed == false)
            {
                serialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                txtSend.Enabled = false;
                btnSend.Enabled = false;
                string directoryPath = "";
                OpenFileDialog openFile1 = new OpenFileDialog();
                openFile1.Filter = "All Files|*.*";

                try
                {
                    string fileName = "";
                    if (openFile1.ShowDialog() == DialogResult.OK)
                    {
                        directoryPath = openFile1.FileName;
                        byte[] writeBuffer = File.ReadAllBytes(directoryPath);
                        fileName = Path.GetFileName(directoryPath);
                        serialPort.WriteLine(fileName);
                        txtBox.AppendText("Enviado: " + fileName + "\n");
                        txtBox.AppendText(Environment.NewLine);
                        serialPort.Write(writeBuffer, 0, writeBuffer.Length);
                        MessageBox.Show("Archivo enviado");
                    }
                }

                catch (ArgumentException)
                {
                    MessageBox.Show("Formato de archivo no permitido");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo abrir el archivo");
                }
            }
            else
            {
                MessageBox.Show("El puerto está cerrado. Abra algún puerto");
            }
            

            //serialPort.Write(openFile1.FileName);
            //txtBox.AppendText("Enviado: " + openFile1.FileName + "\n");
            //txtBox.AppendText(Environment.NewLine);
        }

        private void recibirFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(477, 249);
            serialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);

            lblHeader.Text = "Modo Activo: Recepción";

            if (portClosed == false)
            {
                txtSend.Enabled = false;
                btnSend.Enabled = false;
                try
                {
                    string text = serialPort.ReadLine();
                    txtBox.AppendText("Recibido: " + text + "\n");
                    txtBox.AppendText(Environment.NewLine);
                    byte[] bytes = new byte[serialPort.BytesToRead];
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = text;
                    saveFile.Filter = "All Files|*.*";
                    serialPort.Read(bytes, 0, serialPort.BytesToRead);


                    if (saveFile.ShowDialog() == DialogResult.OK && text.Contains("."))
                    {
                        File.WriteAllBytes(saveFile.FileName, bytes);
                        MessageBox.Show("Archivo recibido y guardado");
                    }
                    else
                    {
                        MessageBox.Show("No hay archivo o tiene un formato inválido.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de Lectura o Escritura");
                }
               
            }
            else
            {
                MessageBox.Show("El puerto está cerrado. Abra algún puerto");
            }
        }

        private void chatTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(477, 249);
            lblHeader.Text = "Modo Activo: Chat";
            txtSend.Enabled = true;
            btnSend.Enabled = true;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }

        private void frmConfig_Shown(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipText = "Bienvenido/a al programa";
            this.notifyIcon.ShowBalloonTip(1000);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        #endregion
    }
}
