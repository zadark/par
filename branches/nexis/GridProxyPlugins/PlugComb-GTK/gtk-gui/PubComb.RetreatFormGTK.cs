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
    
    
    public partial class RetreatFormGTK {
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label lblTitle;
        
        private Gtk.HSeparator hseparator3;
        
        private Gtk.CheckButton chkEnabled;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget PubComb.RetreatFormGTK
            this.Name = "PubComb.RetreatFormGTK";
            this.Title = Mono.Unix.Catalog.GetString("RetreatFormGTK");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child PubComb.RetreatFormGTK.Gtk.Container+ContainerChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.lblTitle = new Gtk.Label();
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.LabelProp = Mono.Unix.Catalog.GetString("Plugin by LGG.");
            this.vbox3.Add(this.lblTitle);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox3[this.lblTitle]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hseparator3 = new Gtk.HSeparator();
            this.hseparator3.Name = "hseparator3";
            this.vbox3.Add(this.hseparator3);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox3[this.hseparator3]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.chkEnabled = new Gtk.CheckButton();
            this.chkEnabled.CanFocus = true;
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Label = Mono.Unix.Catalog.GetString("Alert me when a friend removes me from their contacts list");
            this.chkEnabled.DrawIndicator = true;
            this.chkEnabled.UseUnderline = true;
            this.vbox3.Add(this.chkEnabled);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox3[this.chkEnabled]));
            w3.Position = 2;
            w3.Expand = false;
            w3.Fill = false;
            this.Add(this.vbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 418;
            this.DefaultHeight = 300;
            this.Show();
        }
    }
}
