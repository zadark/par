// (c)2009 Gregory Maurer (SL Name), Rob "N3X15" Nelson, Gregory "LordGregGreg" Hendrickson. All Rights Reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met:
// 
//  * Redistributions of source code must retain the above copyright notice, this 
// 		list of conditions and the following disclaimer.
// 
//  * Redistributions in binary form must reproduce the above copyright notice, this 
// 		list of conditions and the following disclaimer in the documentation and/or 
// 		other materials provided with the distribution.
//  * Neither the name of the  Gregory Hendrickson nor the names of its contributors 
// 		may be used to endorse or promote products derived from this software without 
// 		specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
// IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
// WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE.

using System;
using System.IO;
using Gtk;

namespace PubComb
{
	
	
	public partial class CliIntFormGTK : Gtk.Window
	{
		private CliIntPlugin lp;
		
		public CliIntFormGTK(CliIntPlugin l) : 
				base(Gtk.WindowType.Toplevel)
		{
			lp=l;
			this.Build();
		}
		
		public string getbox()
        {
            return txtInventory.Text;
        }
        public bool getCheck1()
        {
            return chkEnabled.Active;
        }
        /*public bool getCheck2()
        {
            return checkBox2.Checked;
        }*/
        public void setBox(string s)
        {
            txtInventory.Text = s;
        }
        public void setCheck1(bool a)
        {
            chkEnabled.Active = a;
        }
        /*public void setCheck2(bool a)
        {
            checkBox2.Checked = a;
        } */
		
		public void readData()
        {
            bool pass1 = false;
            bool pass2 = false;
            setBox("Objects/RezzedIntercept");
            if (File.Exists("cliint.settings"))
            {
                StreamReader re = File.OpenText("cliint.settings");
                if (re.ReadLine() == "Enabled1")
                  pass1 = true;
				
				if (re.ReadLine() == "Enabled2")
                  pass2 = false;
                string t = re.ReadLine();
                setBox(t);

                re.Close();
                
            }
            setCheck1(pass1);
            setCheck1(pass2);
        }
		
		private void saveData()
        {
            TextWriter tw = new StreamWriter("cliint.settings");
            if (chkEnabled.Active) tw.WriteLine("Enabled1");
            else tw.WriteLine("Disabled1");
            //if (checkBox2.Checked) tw.WriteLine("Enabled2");
            //else tw.WriteLine("Disabled2");
            tw.WriteLine(getbox());
            tw.Close();
        }

		protected virtual void OnChkEnableClicked (object sender, System.EventArgs e)
		{
			saveData();
		}

		protected virtual void OnTxtInventoryEditingDone (object sender, System.EventArgs e)
		{
			lp.ScanForInterceptor();
		}
	}
}
