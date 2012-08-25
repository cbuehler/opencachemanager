// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ocmgtk {
    
    
    public partial class GPSConfiguration {
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label profLabel;
        
        private Gtk.Entry profileEntry;
        
        private Gtk.Notebook notebook1;
        
        private Gtk.Table table1;
        
        private Gtk.ComboBox deviceCombo;
        
        private Gtk.Label deviceLabel;
        
        private Gtk.Label label4;
        
        private ocmgtk.WaypointOverrideWidget waypointWidget;
        
        private Gtk.Label label5;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.GPSConfiguration
            this.WidthRequest = 600;
            this.HeightRequest = 500;
            this.Name = "ocmgtk.GPSConfiguration";
            this.Title = Mono.Unix.Catalog.GetString("Add GPS Profile...");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.Resizable = false;
            this.AllowGrow = false;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Internal child ocmgtk.GPSConfiguration.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.profLabel = new Gtk.Label();
            this.profLabel.Name = "profLabel";
            this.profLabel.Xalign = 0F;
            this.profLabel.LabelProp = Mono.Unix.Catalog.GetString("Profile Name:");
            this.hbox1.Add(this.profLabel);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.profLabel]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.profileEntry = new Gtk.Entry();
            this.profileEntry.CanFocus = true;
            this.profileEntry.Name = "profileEntry";
            this.profileEntry.Text = Mono.Unix.Catalog.GetString("New Profile");
            this.profileEntry.IsEditable = true;
            this.profileEntry.InvisibleChar = '•';
            this.hbox1.Add(this.profileEntry);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.profileEntry]));
            w3.Position = 1;
            w1.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.notebook1 = new Gtk.Notebook();
            this.notebook1.CanFocus = true;
            this.notebook1.Name = "notebook1";
            this.notebook1.CurrentPage = 0;
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.table1 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            this.table1.BorderWidth = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.deviceCombo = Gtk.ComboBox.NewText();
            this.deviceCombo.AppendText(Mono.Unix.Catalog.GetString("Garmin GPX (Colorado/Oregon/Dakotai/Map62/Nuvi 5xx)"));
            this.deviceCombo.AppendText(Mono.Unix.Catalog.GetString("Garmin USB (eTrex/GPSMap60/StreetPiot)"));
            this.deviceCombo.AppendText(Mono.Unix.Catalog.GetString("Garmin Serial (original eTrex/eTrex H/Gecko)"));
            this.deviceCombo.AppendText(Mono.Unix.Catalog.GetString("Garmin Edge (605/705)/Garmin Nuvi"));
            this.deviceCombo.AppendText(Mono.Unix.Catalog.GetString("DeLorme USB (PN-20/PN-30/PN-40)"));
            this.deviceCombo.AppendText(Mono.Unix.Catalog.GetString("DeLorme GPX (PN-60/PN-40 v2.8+)"));
            this.deviceCombo.AppendText(Mono.Unix.Catalog.GetString("Magellan GPX (Explorist GC/310/510/610/710)"));
            this.deviceCombo.AppendText(Mono.Unix.Catalog.GetString("Other GPS"));
            this.deviceCombo.Name = "deviceCombo";
            this.deviceCombo.Active = 0;
            this.table1.Add(this.deviceCombo);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.deviceCombo]));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.deviceLabel = new Gtk.Label();
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Xalign = 0F;
            this.deviceLabel.LabelProp = Mono.Unix.Catalog.GetString("Select a GPS Type:");
            this.table1.Add(this.deviceLabel);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.deviceLabel]));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            this.notebook1.Add(this.table1);
            // Notebook tab
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Device");
            this.notebook1.SetTabLabel(this.table1, this.label4);
            this.label4.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.waypointWidget = new ocmgtk.WaypointOverrideWidget();
            this.waypointWidget.Events = ((Gdk.EventMask)(256));
            this.waypointWidget.Name = "waypointWidget";
            this.notebook1.Add(this.waypointWidget);
            Gtk.Notebook.NotebookChild w8 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.waypointWidget]));
            w8.Position = 1;
            // Notebook tab
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Waypoint Symbols");
            this.notebook1.SetTabLabel(this.waypointWidget, this.label5);
            this.label5.ShowAll();
            w1.Add(this.notebook1);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.notebook1]));
            w9.Position = 1;
            // Internal child ocmgtk.GPSConfiguration.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Name = "dialog1_ActionArea";
            w10.Spacing = 10;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonCancel]));
            w11.Expand = false;
            w11.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonOk]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 602;
            this.DefaultHeight = 533;
            this.buttonOk.HasDefault = true;
            this.Show();
            this.deviceCombo.Changed += new System.EventHandler(this.OnComboChange);
            this.buttonCancel.Clicked += new System.EventHandler(this.OnButtonClick);
            this.buttonOk.Clicked += new System.EventHandler(this.OnButtonClick);
        }
    }
}
