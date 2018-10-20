using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Pipes;

namespace Pipe
{
    public partial class Form1 : Form
    {
        public bool connected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (NamedPipeClientStream pipe = new NamedPipeClientStream(".", "colourPipe", PipeDirection.In))
            {
                lblconnect.Text = "connecting";
                pipe.Connect();

                listboxColours.Items.Add("Connected");
                lblconnect.Text = "Connected";
               
                    using (StreamReader reader = new StreamReader(pipe))
                    {
                    listboxColours.Items.Clear();
                    
                        string temp;
                 
                        while ((temp = reader.ReadLine()) != null)
                        {
                            listboxColours.Items.Add(temp);
                        }

                    
                }
            }
            }

        }
}
