﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;

namespace ColoursOfTheRainbow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            string file = "coloursjsn.text";
            Dictionary<string, string> colours = new Dictionary<string, string>();

            colours.Add("Black", "#000000");
            colours.Add("Maroon", "#800000");
            colours.Add("Dark-Violet","#9400D3");
            colours.Add("Crimson", "#DC143C");

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

                labelColour.ForeColor = ColorTranslator.FromHtml(val.Value);

                y += 30;
                labelColour.Size = new Size(200, 30);

            }
        }
    }
}
