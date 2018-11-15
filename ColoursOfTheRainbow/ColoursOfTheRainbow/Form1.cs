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

using Newtonsoft.Json;

namespace ColoursOfTheRainbow
{
   
    public partial class Form1 : Form
    {
        public string searchString = "";
        
        KeyPressEventHandler kpHandler;
        public bool connected = false;
        List<Colour> colourList = new List<Colour>();

        private void Form1_Load(object sender,EventArgs e)
        {
            kpHandler = new KeyPressEventHandler(KeyPressed);
            txtsearch.KeyPress += kpHandler;
        }
        public Form1()

        {
            InitializeComponent();
            btnsend.Visible = false;

        }
        public void KeyPressed(object sender,KeyPressEventArgs e)
        {
           
                //if ((e.KeyChar >= (char)Keys.A && e.KeyChar <= 122) || (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9))
                //{
                //    searchString += e.KeyChar.ToString();
                //    labelsearch.Text = searchString;
                //    txtsearch.Text = "";
                //}
                switch(e.KeyChar)
                {
                case '\b':
                    if (searchString.Length >= 1 )
                    {
                        searchString = searchString.Remove(searchString.Length - 1);
                    }
                    labelsearch.Text = searchString;
                    break;
                default:
                    
                    searchString += e.KeyChar.ToString();
                    labelsearch.Text = searchString;
                    break;
                }

                foreach(var col in colourList)
            {
                if(searchString == col.name)
                {
                    labelsearch.ForeColor = ColorTranslator.FromHtml(col.hexCode);
                    break;
                }
                else
                {
                    labelsearch.ForeColor = Color.Black;
                }
            }
            
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            //https://www.newtonsoft.com/json/help/html/SerializingJSON.htm newtonsoft json documentation
            string file = "coloursjsn.text";
            Dictionary<string, string> colours = new Dictionary<string, string>();

            colours.Add("black", "#000000");
            colours.Add("maroon", "#800000");
            colours.Add("dark-violet","#9400D3");
            colours.Add("crimson", "#DC143C");

           
            string json = JsonConvert.SerializeObject(colours);

            File.WriteAllText(file, json);

            json = "";

            json = File.ReadAllText(file);

            Dictionary<string, string> deserialisedColours= JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            int x = 50;
            int y = 100;
            foreach (var val in deserialisedColours)
            {
                Label labelColour = new Label();

                this.Controls.Add(labelColour);

                labelColour.Location = new Point(x, y);
                labelColour.Text = $"Colour {val.Key} Code {val.Value}";
                Colour newColour = new Colour();
                newColour.name = val.Key;
                newColour.hexCode = val.Value;
                colourList.Add(newColour);
                labelColour.ForeColor = ColorTranslator.FromHtml(val.Value);

                y += 30;
                labelColour.Size = new Size(200, 30);

            }
            Searchbtn.Enabled = true;
            txtsearch.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NamedPipeServerStream pipe = new NamedPipeServerStream("colourPipe", PipeDirection.Out))
            {
                lblconnection.Text = "Connecting";
                pipe.WaitForConnection();
                lblconnection.Text = "Connected";
                btnsend.Visible = true;
                connected = true;

                using (StreamWriter writer = new StreamWriter(pipe))
                {
                   
                    Dictionary<string, string> colours = new Dictionary<string, string>();
                    colours.Add("Black", "#000000");
                    colours.Add("Maroon", "#800000");
                    colours.Add("Dark-Violet", "#9400D3");
                    colours.Add("Crimson", "#DC143C");

                    foreach(var val in colours)
                    {
                        writer.AutoFlush = true;
                        writer.WriteLine(val.Key + val.Value);
                       // Console.WriteLine(val.Key + val.Value);
                        
                    }
                }
            }
        }

      
    }
}
