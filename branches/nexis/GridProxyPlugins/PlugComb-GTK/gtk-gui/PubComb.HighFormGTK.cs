// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace PubComb {
    
    
    public partial class HighFormGTK {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Label lblTitle;
        
        private Gtk.HSeparator hseparator1;
        
        private Gtk.CheckButton chkRezPlatform;
        
        private Gtk.CheckButton chkTP2Plat;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label lblAltitude;
        
        private Gtk.SpinButton spinAltitude;
        
        private Gtk.Button cmdGo;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget PubComb.HighFormGTK
            this.Name = "PubComb.HighFormGTK";
            this.Title = Mono.Unix.Catalog.GetString("HighFormGTK");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child PubComb.HighFormGTK.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.lblTitle = new Gtk.Label();
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.LabelProp = Mono.Unix.Catalog.GetString("Plugin by LGG.\n\nThanks to Day Oh for inviting me to his sky party :)");
            this.lblTitle.Justify = ((Gtk.Justification)(2));
            this.vbox1.Add(this.lblTitle);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.lblTitle]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hseparator1 = new Gtk.HSeparator();
            this.hseparator1.Name = "hseparator1";
            this.vbox1.Add(this.hseparator1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.chkRezPlatform = new Gtk.CheckButton();
            this.chkRezPlatform.CanFocus = true;
            this.chkRezPlatform.Name = "chkRezPlatform";
            this.chkRezPlatform.Label = Mono.Unix.Catalog.GetString("Rez a platform up high.");
            this.chkRezPlatform.Active = true;
            this.chkRezPlatform.DrawIndicator = true;
            this.chkRezPlatform.UseUnderline = true;
            this.vbox1.Add(this.chkRezPlatform);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.chkRezPlatform]));
            w3.Position = 2;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.chkTP2Plat = new Gtk.CheckButton();
            this.chkTP2Plat.CanFocus = true;
            this.chkTP2Plat.Name = "chkTP2Plat";
            this.chkTP2Plat.Label = Mono.Unix.Catalog.GetString("TP me to platform after rezzing it.");
            this.chkTP2Plat.Active = true;
            this.chkTP2Plat.DrawIndicator = true;
            this.chkTP2Plat.UseUnderline = true;
            this.vbox1.Add(this.chkTP2Plat);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.chkTP2Plat]));
            w4.Position = 3;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.lblAltitude = new Gtk.Label();
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.LabelProp = Mono.Unix.Catalog.GetString("Altitude to rez at:");
            this.hbox2.Add(this.lblAltitude);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox2[this.lblAltitude]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.spinAltitude = new Gtk.SpinButton(0, 112000, 1);
            this.spinAltitude.CanFocus = true;
            this.spinAltitude.Name = "spinAltitude";
            this.spinAltitude.Adjustment.PageIncrement = 10;
            this.spinAltitude.ClimbRate = 1;
            this.spinAltitude.Numeric = true;
            this.spinAltitude.Value = 4097;
            this.hbox2.Add(this.spinAltitude);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox2[this.spinAltitude]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            this.vbox1.Add(this.hbox2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
            w7.Position = 4;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.cmdGo = new Gtk.Button();
            this.cmdGo.CanFocus = true;
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.UseUnderline = true;
            this.cmdGo.Label = Mono.Unix.Catalog.GetString("Take a Hit");
            this.vbox1.Add(this.cmdGo);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox1[this.cmdGo]));
            w8.Position = 5;
            w8.Expand = false;
            w8.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.chkRezPlatform.Toggled += new System.EventHandler(this.OnChkRezPlatformToggled);
            this.chkTP2Plat.Toggled += new System.EventHandler(this.OnChkTP2PlatToggled);
            this.spinAltitude.Changed += new System.EventHandler(this.OnSpinAltitudeChanged);
            this.cmdGo.Activated += new System.EventHandler(this.OnCmdGoActivated);
        }
    }
}