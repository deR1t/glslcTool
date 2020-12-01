using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glslcTool
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void compilebutton_Click(object sender, EventArgs e)
        {


            string final = "";

            string stg = bstage.Text;
            if (stg != "") { final += " -fshader-stage=" + stg; }

            string inp = binput.Text;
            final += " \"" + inp + "\"";

            string otp = boutput.Text;
            final += " -o \"" + otp + "\"";

            final += " --target-env=vulkan1.2 ";

            debugCube.AppendText("glslc " + final);
            debugCube.AppendText(Environment.NewLine);

            if(((Button)sender).Name != "previewbutton")
            {

                Process prc = new Process();
                ProcessStartInfo si = new ProcessStartInfo("glslc", final);
                si.UseShellExecute = false;
                si.RedirectStandardOutput = true;
                si.RedirectStandardError = true;
                prc.StartInfo = si;
                prc.Start();

                debugCube.AppendText(prc.StandardOutput.ReadToEnd());
                debugCube.AppendText(prc.StandardError.ReadToEnd());

                prc.WaitForExit();

            }

        }

        private void DragDropLogic(object sender, DragEventArgs e)
        {

            //((Button)sender).BackColor = Color.Red;

            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (files != null && files.Any())
            {

                ((TextBox)sender).Text = files.First();
                

            }

        }

        private void DragDropEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
            {
                e.Effect = DragDropEffects.Copy; 
            }
        }


    }

}
